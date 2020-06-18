﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.EntityFrameworkCore;
using LojaVirtual.Repositories;
using LojaVirtual.Repositories.Contracts;
using LojaVirtual.Libraries.Sessao;
using LojaVirtual.Libraries.Login;
using System.Net.Mail;
using System.Net;
using LojaVirtual.Libraries.Middleware;
using LojaVirtual.Libraries.CarrinhoCompra;
using AutoMapper;
using LojaVirtual.Libraries.AutoMapper;
using LojaVirtual.Libraries.Gerenciador.Frete;
using WSCorreios;
using LojaVirtual.Libraries;
using LojaVirtual.Libraries.Gerenciador.Pagamento.PagarMe;
using LojaVirtual.Libraries.Email;

namespace LojaVirtual
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }


        public void ConfigureServices(IServiceCollection services)
        {
            /*
             * AutoMapper
             */

            services.AddAutoMapper(config => config.AddProfile<MappingProfile>());

            /*
             * Padrão Repository
             */
            services.AddHttpContextAccessor();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<INewsletterRepository, NewsletterRepository>();
            services.AddScoped<IColaboradorRepository, ColaboradorRepository>();
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            services.AddScoped<IProdutoRepository, ProdutoRepository>();
            services.AddScoped<IImagemRepository, ImagemRepository>();
            services.AddScoped<IEnderecoEntregaRepository, EnderecoEntregaRepository>();
            services.AddScoped<IPedidoRepository, PedidoRepository>();
            services.AddScoped<IPedidoSituacaoRepository, PedidoSituacaoRepository>();

            /*
             * SMTP
             */
            services.AddScoped<SmtpClient>(options =>
            {
                SmtpClient smtp = new SmtpClient()
                {
                    Host = Configuration.GetValue<string>("Email:ServerSMTP"),
                    Port = Configuration.GetValue<int>("Email:ServerPort"),
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(Configuration.GetValue<string>("Email:Username"), Configuration.GetValue<string>("Email:Password")),
                    EnableSsl = true
                };

                return smtp;
            });
            services.AddScoped<CalcPrecoPrazoWSSoap>(options => {
                var servico = new CalcPrecoPrazoWSSoapClient(CalcPrecoPrazoWSSoapClient.EndpointConfiguration.CalcPrecoPrazoWSSoap);
                return servico;
            });
            services.AddScoped<GerenciarEmail>();
            services.AddScoped<LojaVirtual.Libraries.Cookie.Cookie>();
            services.AddScoped<CookieCarrinhoCompra>();
            services.AddScoped<CookieFrete>();
            services.AddScoped<CalcularPacote>();
            services.AddScoped<WSCorreiosCalcularFrete>();

            services.Configure<CookiePolicyOptions>(options =>
            {

                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            /*
             * Session - Configuração
             */
            services.AddMemoryCache(); //Guardar os dados na memória
            

            services.AddScoped<Sessao>();
            services.AddScoped<LojaVirtual.Libraries.Cookie.Cookie>();
            services.AddScoped<LoginCliente>();
            services.AddScoped<LoginColaborador>();
            services.AddScoped<GerenciarPagarMe>();


            services.AddMvc(options =>
            {
                options.ModelBindingMessageProvider.SetValueMustNotBeNullAccessor(x => "O campo deve ser preenchido!");
            }).SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
            .AddSessionStateTempDataProvider();

            services.AddSession(options =>
            {
                options.Cookie.IsEssential = true;
            });

            /* USO DO SQL SERVER LOCAL*/
            string connection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaVirtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connection));

            /* USO DO SQL SERVER HOSPEDAGEM
            string connectionHost = "Server=apolo.hostsrv.org;Database=trayclou_;User Id=lojavirtual;Password=l0j@v!rtu@l2020;";
            services.AddDbContext<LojaVirtualContext>(options => options.UseSqlServer(connectionHost));*/


            /* USO DO MYSQL
            string connectionMysql = "Server=apolo.hostsrv.org;Database=LojaVirtual;Uid=lojavirtual;Pwd=l0j@v!rtu@l2020;";
            services.AddDbContext<LojaVirtualContext>(options => options.UseMySql(connectionMysql)); */
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseExceptionHandler("/Error/Error500");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            if (env.IsProduction())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseExceptionHandler("/Error/Error500");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            else
            {
                app.UseStatusCodePagesWithReExecute("/Error/{0}");
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseSession();
            app.UseMiddleware<ValidateAntiForgeryTokenMiddleware>();

            /*
             * https://www.site.com.br -> Qual controlador? (Gestão) -> Rotas
             * https://www.site.com.br/Produto/Visualizar/MouseRazorZK
             * https://www.site.com.br/Produto/Visualizar/10
             * https://www.site.com.br/Produto/Visualizar -> Listagem de todos os produtos
             * 
             * https://www.site.com.br -> https://www.site.com.br/Home/Index
             * https://www.site.com.br/Produto -> https://www.site.com.br/Produto/Index
             */
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "areas",
                    template: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
                  );
                routes.MapRoute(
                    name: "default",
                    template: "/{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
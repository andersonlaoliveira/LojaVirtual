using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.Text;
using LojaVirtual.Database;
using LojaVirtual.Libraries;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Http;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Models.ViewModel;
using LojaVirtual.Libraries.Email;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        
        private INewsletterRepository _repositoryNewsletter;
        
        private GerenciarEmail _gerenciarEmail;
        private IProdutoRepository _produtoRepository;

        public HomeController(IProdutoRepository produtoRepository, IClienteRepository repositoryCliente, INewsletterRepository repositoryNewsletter, GerenciarEmail gerenciarEmail)
        {
            _repositoryNewsletter = repositoryNewsletter;
            _gerenciarEmail = gerenciarEmail;
            _produtoRepository = produtoRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index([FromForm]NewsletterEmail newsletter)
        {
            if (ModelState.IsValid)
            {
                _repositoryNewsletter.Cadastrar(newsletter);
                /*ANTIGO...
                _banco.NewsletterEmails.Add(newsletter);
                _banco.SaveChanges();
                */
                TempData["MSG_S"] = "E-mail cadastrado com sucesso!";
                
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }

        public IActionResult Categoria()
        {
            return View();
        }

        public IActionResult Contato()
        {
            return View();
        }
        
        public IActionResult ContatoAcao()
        {
            try
            {
                Contato contato = new Contato();
                contato.Nome = HttpContext.Request.Form["nome"];
                contato.Email = HttpContext.Request.Form["email"];
                contato.Texto = HttpContext.Request.Form["texto"];

                var listaMensagens = new List<ValidationResult>();
                var contexto = new ValidationContext(contato);
                bool isValid = Validator.TryValidateObject(contato, contexto, listaMensagens, true);

                if (isValid)
                {
                    _gerenciarEmail.EnviarContatoPorEmail(contato);

                    ViewData["MSG_S"] = "Mensagem de contato enviado com sucesso!";
                }
                else
                {
                    StringBuilder sb = new StringBuilder();
                    foreach (var texto in listaMensagens)
                    {
                        sb.Append(texto.ErrorMessage + "<br />");
                    }
                    ViewData["MSG_E"] = sb.ToString();
                    ViewData["CONTATO"] = contato;

                }
            }
            catch (Exception e)
            {
                ViewData["MSG_E"] = "Opps! Ocorreu um erro, tente novamente mais tarde.";

                //TODO - Implementar log
            }
            //

            /*
            return new ContentResult() { Content = string.Format("Dados recebidos com sucesso! " +
                " <br> Nome: {0} <br> E-mail: {1} <br>Texto: {2}",
                contato.Nome, contato.Email, contato.Texto),
                ContentType = "text/html"
            };
            */ 
            return View("Contato");
        }


    }
}
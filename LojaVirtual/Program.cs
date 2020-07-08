using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using LojaVirtual.Libraries.Bug;
using Serilog;
using Serilog.Events;
using System;
using System.IO;
using Serilog.Sinks.MSSqlServer.Sinks.MSSqlServer.Options;
using Microsoft.Extensions.Configuration;

namespace LojaVirtual
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //CurrentDirectoryHelpers.SetCurrentDirectory();
            //string caminhoLog = Path.Combine(Directory.GetCurrentDirectory(), "Logs.txt");

            /*
            Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Debug()
            .MinimumLevel.Override("Microsoft", LogEventLevel.Error)
            .Enrich.FromLogContext()
            .WriteTo.File(caminhoLog)
            .CreateLogger();
            */

            Log.Logger = new LoggerConfiguration()
            .WriteTo
            .MSSqlServer(
                connectionString: "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=LojaVirtual;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;",
                sinkOptions: new SinkOptions { TableName = "Logs" })
            .CreateLogger();

            try
            {
                Log.Information("--- SERVIDOR INICIANDO ---");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "--- SERVIDOR TERMINOU INESPERADAMENTE ---");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .UseSerilog();
    }
}
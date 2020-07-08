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
using Microsoft.Extensions.Logging;

namespace LojaVirtual.Controllers
{
    public class HomeController : Controller
    {
        
        private INewsletterRepository _repositoryNewsletter;
        
        private GerenciarEmail _gerenciarEmail;
        private IProdutoRepository _produtoRepository;
        private ILogger<HomeController> _logger;

        public HomeController(IProdutoRepository produtoRepository, IClienteRepository repositoryCliente, INewsletterRepository repositoryNewsletter, GerenciarEmail gerenciarEmail, ILogger<HomeController> logger)
        {
            _repositoryNewsletter = repositoryNewsletter;
            _gerenciarEmail = gerenciarEmail;
            _produtoRepository = produtoRepository;
            _logger = logger;
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

                _logger.LogError(e, "HomeController > ContatoAcao - Exception");
            }
             
            return View("Contato");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LojaVirtual.Libraries.Filtro;
using LojaVirtual.Libraries.Login;
using LojaVirtual.Models;
using LojaVirtual.Repositories.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace LojaVirtual.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class HomeController : Controller
    {
        private LoginCliente _loginCliente;
        private IClienteRepository _repositoryCliente;
        private IEnderecoEntregaRepository _repositoryEnderecoEntrega;
        public HomeController(IClienteRepository repositoryCliente, LoginCliente loginCliente, IEnderecoEntregaRepository repositoryEnderecoEntrega)
        {
            _loginCliente = loginCliente;
            _repositoryCliente = repositoryCliente;
            _repositoryEnderecoEntrega = repositoryEnderecoEntrega;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login([FromForm]Models.Cliente cliente, string returnUrl = null)
        {
            Models.Cliente clienteDB = _repositoryCliente.Login(cliente.Email, cliente.Senha);

            if (clienteDB != null)
            {
                _loginCliente.Login(clienteDB);

                if(returnUrl == null)
                {
                    return new RedirectResult(Url.Action(nameof(Painel)));
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
                
            }
            else
            {
                ViewData["MSG_E"] = "Login ou senha não localizados. Verifique os dados digitados!";
                return View();
            }

        }

        [HttpGet]
        [ClienteAutorizacao]
        public IActionResult Painel()
        {
            return new ContentResult() { Content = "Este é o painel do cliente!" };
        }


        [HttpGet]
        public IActionResult CadastroCliente()
        {
            return View();
        }


        [HttpPost]
        public IActionResult CadastroCliente([FromForm] Models.Cliente cliente, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                _repositoryCliente.Cadastrar(cliente);
                _loginCliente.Login(cliente);

                TempData["MSG_S"] = "Cadastro realizado com sucesso!";

                if (returnUrl == null)
                {
                    return RedirectToAction("Index", "Home", new { area = "" });
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }
            }
            return View();
        }



        [HttpGet]
        public IActionResult CadastroEnderecoEntrega()
        {
            //TODO - Melhorar o HTML do campo Nome.
            //TODO - Remover do javascript a opção de carregar o CEP ele esta no cookie para esta tela.
            return View();
        }
        
        [HttpPost]
        public IActionResult CadastroEnderecoEntrega([FromForm]EnderecoEntrega enderecoentrega, string returnUrl = null)
        {
            if (ModelState.IsValid)
            {
                enderecoentrega.ClienteId = _loginCliente.GetCliente().Id;

                _repositoryEnderecoEntrega.Cadastrar(enderecoentrega);
                
                if(returnUrl == null)
                {
                    //TODO - Listagem de endereços
                }
                else
                {
                    return LocalRedirectPermanent(returnUrl);
                }

            }
            return View();
        }
    }
}
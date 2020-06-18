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
                    return RedirectToAction("Index", "Home", new { area = "" });
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
        public IActionResult Sair()
        {
            _loginCliente.Logout();
            return RedirectToAction("Index", "Home", new { area = "" });
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
    }
}
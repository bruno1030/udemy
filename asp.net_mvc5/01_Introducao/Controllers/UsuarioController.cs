using _01_Introducao.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _01_Introducao.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario
        public ActionResult Cadastrar()
        {
            var usuario = new Usuario();
            return View(usuario);
        }


        [HttpPost]
        public ActionResult Cadastrar(Usuario usuario)
        {

            //if (string.IsNullOrEmpty(usuario.Nome))
            //{
            //    ModelState.AddModelError("Nome", "O campo nome eh obrigatorio");
            //}

            //if (usuario.Senha != usuario.ConfirmarSenha)
            //{
            //    ModelState.AddModelError("", "As senhas nao conferem");
            //}

            if (ModelState.IsValid)     // se tiver validado corretamente o usuario       
            {
                //TempData["msg"] = "Cadastrado!";
                return View("Listar", usuario);       //retornara o metodo "Resultado"
            }
            return View(usuario);
        }


        [HttpGet]
        public ActionResult Listar()
        {
            return View();
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplo = new Collection<string>
            {
                "loginBruno",
                "loginGuga",
                "loginLucas"
            };

            // aqui abaixo ele verifica se o login digitado pelo usuario eh diferente do que ja tem no banco de dados. Pra isso, ele transforma tudo em minusculo, tanto os que estao no banco de dados, como o que esta sendo digitado pelo usuario
            return Json(bdExemplo.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }
    }
}
using _01_Introducao.Models;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
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

    }
}
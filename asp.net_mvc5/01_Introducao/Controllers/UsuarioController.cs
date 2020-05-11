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
        public ActionResult Index()
        {
            var usuario = new Usuario();
            return View(usuario);
        }

        /*
        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)         // se tiver validado corretamente o usuario
            //{
             //   return View("Resultado", usuario);       //retornara o metodo "Resultado"
            //}
            return View(usuario);
        }
        */

        public ActionResult Resultado()
        {
            return View();
        }
    }
}
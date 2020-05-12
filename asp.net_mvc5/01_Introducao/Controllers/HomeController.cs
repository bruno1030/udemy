// .. bibliotecas padroes que vem
using _01_Introducao.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace _01_Introducao.Controllers                      // .. namespace
{
   
    public class HomeController : Controller             //..toda classe Controller herda de Controller
    {
        // GET: Home                                     
        public ActionResult Index()              //esse funcao se chama Index, , do tipo ActionResult, e retorna uma View
        {
            
            var pessoa = new Pessoa
            {
                PessoaId = 1,
                Nome = "Bruno Martins",
                Tipo = "Analista de Sistemas"
        };

            ViewData["PessoaId"] = pessoa.PessoaId;
            ViewData["Nome"] = pessoa.Nome;
            ViewData["Tipo"] = pessoa.Tipo;

            ViewBag.pessoaId = pessoa.PessoaId;
            ViewBag.nome = pessoa.Nome;
            ViewBag.tipo = pessoa.Tipo;

            return View(pessoa);           // o parametro ali dentro significa que a variavel "pessoa" sera enviada para a View quando ela for carregada
        
        }

        public ActionResult Contato()
        {
            return View();
        }

        public ActionResult Sobre()
        {
            return View();
        }


        /*
        [HttpPost]                     // esse post significa que esse metodo sera para Enviar informacoes, e nao receber
        public ActionResult Lista(int PessoaId, string Nome, string Tipo)
        {
            ViewBag.PessoaId = PessoaId;
            ViewBag.Nome = Nome;
            ViewBag.Tipo = Tipo;

            return View();
        }
        */


        [HttpPost]                     // esse post significa que esse metodo sera para Enviar informacoes, e nao receber
        public ActionResult Lista(Pessoa pessoa)
        {
            ViewBag.pessoaId = pessoa.PessoaId;
            ViewBag.nome = pessoa.Nome;
            ViewBag.tipo = pessoa.Tipo;

            return View(pessoa);
        }


    }
}
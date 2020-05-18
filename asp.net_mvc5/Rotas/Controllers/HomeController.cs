using Rotas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rotas.Controllers
{
    public class HomeController : Controller
    {

        private readonly IEnumerable<Noticia> todasAsNoticias;     //isso daqui eh uma variavel chamada "todasAsNoticias", na qual vou associar aos valores do Objeto "TodasAsNoticias", criado la na Model

        public HomeController()    //se eu crio um metodo publico como esse, que tem o mesmo NOME da classe, significa que estou criando o Construtor dessa classe. 
        {
            todasAsNoticias = new Noticia().TodasAsNoticias().OrderByDescending(x => x.Data); // ordenado pela data

        }
        public ActionResult Index()
        {
            var ultimasNoticias = todasAsNoticias.Take(3);
            var todasAsCategorias = todasAsNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasAsCategorias;
            return View(ultimasNoticias);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
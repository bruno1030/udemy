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

        public ActionResult TodasAsNoticias()
        {
            return View(todasAsNoticias);
        }

        public ActionResult MostraNoticia(int noticiaId, string titulo, string categoria)
        {
            return View(todasAsNoticias.FirstOrDefault(x => x.NoticiaId == noticiaId));
        }

        public ActionResult MostraCategoria(string categoria)
        {
            var categoriaEspecifica = todasAsNoticias.Where(x => x.Categoria.ToLower() == categoria.ToLower()).ToList();        //esse   "x => x.Categoria"   significa que o parametro x recebe x.Categoria.....  a Categoria com letra maiuscula eh o que esta no banco de dados, e o categoria com c minusculo eh o parametro que estamos passando

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
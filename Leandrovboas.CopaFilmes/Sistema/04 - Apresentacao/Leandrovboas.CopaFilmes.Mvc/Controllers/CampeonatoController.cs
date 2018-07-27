using Leandrovboas.CopaFilmes.Mvc.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace Leandrovboas.CopaFilmes.Mvc.Controllers
{
    public class CampeonatoController : Controller
    {
        [Route("Index/{filmes}")]
        public ActionResult Index(ICollection<FilmeViewModel> filmes)
        {
            ViewBag.ListaFilmes = filmes;
            return View();
        }
    }
}
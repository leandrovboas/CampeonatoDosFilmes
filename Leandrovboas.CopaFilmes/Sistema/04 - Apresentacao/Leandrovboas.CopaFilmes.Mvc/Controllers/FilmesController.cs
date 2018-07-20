using System.Web.Mvc;

namespace Leandrovboas.CopaFilmes.Mvc.Controllers
{
    public class FilmesController : Controller
    {
        // GET: Filmes
        public ActionResult Index()
        {
            return View();
        }
    }
}
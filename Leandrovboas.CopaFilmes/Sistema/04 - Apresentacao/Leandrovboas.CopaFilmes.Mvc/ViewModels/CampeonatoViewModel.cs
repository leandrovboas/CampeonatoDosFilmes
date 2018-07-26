using Leandrovboas.CopaFilmes.Mvc.ViewModels;

namespace Leandrovboas.CopaFilmes.Mvc.Controllers.Api
{
    public class CampeonatoViewModel
    {
        public FaseDeGrupoViewModel FaseDeGrupo { get; set; }
        public FaseEliminatoriaViewModel FaseEliminatoria { get; set; }
        public FaseSemiFinalViewModel FaseSemiFinal { get; set; }
        public FaseFinalViewModel FaseFinal { get; set; }
    }
}
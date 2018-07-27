using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Mvc.ViewModels
{
    public class FaseDeGrupoViewModel
    {
        public List<FilmeViewModel> GrupoA { get; set; }
        public List<FilmeViewModel> GrupoB { get; set; }
        public List<FilmeViewModel> GrupoC { get; set; }
        public List<FilmeViewModel> GrupoD { get; set; }
    }
}
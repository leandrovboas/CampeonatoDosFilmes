using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Mvc.ViewModels
{
    public class FaseDeGrupoViewModel
    {
        public List<FilmeViewModel> GrupoA { get; }
        public List<FilmeViewModel> GrupoB { get; }
        public List<FilmeViewModel> GrupoC { get; }
        public List<FilmeViewModel> GrupoD { get; }
    }
}
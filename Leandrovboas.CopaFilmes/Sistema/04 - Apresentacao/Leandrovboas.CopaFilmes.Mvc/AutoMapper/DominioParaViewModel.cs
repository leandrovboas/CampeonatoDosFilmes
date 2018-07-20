using AutoMapper;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Mvc.ViewModels;

namespace Leandrovboas.CopaFilmes.Mvc.AutoMapper
{
    public class DominioParaViewModel : Profile
    {
        public DominioParaViewModel() => CreateMap<FilmeViewModel, Filme>();
    }
}
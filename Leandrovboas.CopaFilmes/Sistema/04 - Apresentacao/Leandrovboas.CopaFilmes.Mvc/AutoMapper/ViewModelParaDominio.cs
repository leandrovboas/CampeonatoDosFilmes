using AutoMapper;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Mvc.ViewModels;

namespace Leandrovboas.CopaFilmes.Mvc.AutoMapper
{
    public class ViewModelParaDominio : Profile
    {
        public ViewModelParaDominio() => CreateMap<Filme, FilmeViewModel>();
    }
}
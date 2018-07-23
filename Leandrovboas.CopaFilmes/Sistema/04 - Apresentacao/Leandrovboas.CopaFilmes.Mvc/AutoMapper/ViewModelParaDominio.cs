using AutoMapper;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Mvc.ViewModels;

namespace Leandrovboas.CopaFilmes.Mvc.AutoMapper
{
    public class ViewModelParaDominio : Profile
    {
        public ViewModelParaDominio() => CreateMap<Filme, FilmeViewModel>()
            .ForMember(dest => dest.Titulo, opt => opt.MapFrom(src => src.PrimaryTitle))
            .ForMember(dest => dest.Nota, opt => opt.MapFrom(src => src.AverageRating))
            .ForMember(dest => dest.AnoLancamento, opt => opt.MapFrom(src => src.Year));
    }
}
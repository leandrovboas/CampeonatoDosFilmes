using AutoMapper;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Mvc.Controllers.Api;
using Leandrovboas.CopaFilmes.Mvc.ViewModels;

namespace Leandrovboas.CopaFilmes.Mvc.AutoMapper
{
    public class DominioParaViewModel : Profile
    {
        public DominioParaViewModel()
        {
            CreateMap<FilmeViewModel, Filme>()
                .ForMember(dest => dest.PrimaryTitle, opt => opt.MapFrom(src => src.Titulo))
                .ForMember(dest => dest.AverageRating, opt => opt.MapFrom(src => src.Nota))
                .ForMember(dest => dest.Year, opt => opt.MapFrom(src => src.AnoLancamento));

            CreateMap<CampeonatoViewModel, Campeonato>();
        }
    }
}
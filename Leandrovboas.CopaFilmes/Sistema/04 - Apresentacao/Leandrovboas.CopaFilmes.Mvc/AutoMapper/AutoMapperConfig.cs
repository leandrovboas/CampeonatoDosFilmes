using AutoMapper;

namespace Leandrovboas.CopaFilmes.Mvc.AutoMapper
{
    public class AutoMapperConfig
    {
        public static void RegistrarMapeamento()
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<DominioParaViewModel>();
                x.AddProfile<ViewModelParaDominio>();
            });
        }
    }
}
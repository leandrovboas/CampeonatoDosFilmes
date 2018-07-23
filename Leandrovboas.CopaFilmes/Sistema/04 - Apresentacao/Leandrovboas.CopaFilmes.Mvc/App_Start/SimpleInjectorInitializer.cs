[assembly: WebActivator.PostApplicationStartMethod(typeof(Leandrovboas.CopaFilmes.Mvc.App_Start.SimpleInjectorInitializer), "Initialize")]

namespace Leandrovboas.CopaFilmes.Mvc.App_Start
{
    using Leandrovboas.CopaFilmes.Aplicacao.Interfaces;
    using Leandrovboas.CopaFilmes.Aplicacao.Servicos;
    using Leandrovboas.CopaFilmes.Dominio.Interfaces.Repositorio;
    using Leandrovboas.CopaFilmes.Dominio.Interfaces.Servico;
    using Leandrovboas.CopaFilmes.Dominio.Servicos;
    using Leandrovboas.CopaFilmes.Infra.Repositorio;
    using SimpleInjector;
    using SimpleInjector.Integration.Web;
    using SimpleInjector.Integration.Web.Mvc;
    using SimpleInjector.Integration.WebApi;
    using System.Reflection;
    using System.Web.Http;
    using System.Web.Mvc;

    public static class SimpleInjectorInitializer
    {
        /// <summary>Initialize the container and register it as MVC3 Dependency Resolver.</summary>
        public static void Initialize()
        {
            var container = new Container();
            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();

            InitializeContainer(container);

            container.RegisterMvcControllers(Assembly.GetExecutingAssembly());
            container.RegisterWebApiControllers(GlobalConfiguration.Configuration);

            container.Verify();

            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }

        private static void InitializeContainer(Container container)
        {
            container.Register<IFilmesRepositorio, FilmesRepositorio>(Lifestyle.Scoped);
            container.Register<IFilmeServico, FilmeServico>(Lifestyle.Scoped);
            container.Register<IFilmeServicoApp, FilmeServicoApp>(Lifestyle.Scoped);
        }
    }
}
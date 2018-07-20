using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Dominio.Interfaces.Repositorio;
using Leandrovboas.CopaFilmes.Dominio.Interfaces.Servico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leandrovboas.CopaFilmes.Dominio.Servicos
{
    public class FilmeServico : IFilmeService
    {
        private readonly IFilmesRepositorio FilmeRepositorio;

        public FilmeServico(IFilmesRepositorio filmeRepositorio)
        {
            FilmeRepositorio = filmeRepositorio;
        }

        public Task<IEnumerable<Filme>> GetAllAsync() =>
            FilmeRepositorio.GetAllAsync();
    }
}

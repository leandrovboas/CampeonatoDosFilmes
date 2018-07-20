using Leandrovboas.CopaFilmes.Dominio.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leandrovboas.CopaFilmes.Dominio.Interfaces.Repositorio
{
    public interface IFilmesRepositorio
    {
        Task<IEnumerable<Filme>> GetAllAsync();
    }
}

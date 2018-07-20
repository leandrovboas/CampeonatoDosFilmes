using Leandrovboas.CopaFilmes.Dominio.Entity;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leandrovboas.CopaFilmes.Aplicacao.Interfaces
{
    public interface IFilmeServicoApp
    {
        Task<IEnumerable<Filme>> GetAllAsync();
    }
}

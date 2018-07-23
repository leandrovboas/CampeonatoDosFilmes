using Leandrovboas.CopaFilmes.Aplicacao.Interfaces;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Dominio.Interfaces.Servico;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Leandrovboas.CopaFilmes.Aplicacao.Servicos
{
    public class FilmeServicoApp : IFilmeServicoApp
    {
        private readonly IFilmeServico FilmeServico;

        public FilmeServicoApp(IFilmeServico filmeServico)
        {
            FilmeServico = filmeServico;
        }

        public Task<IEnumerable<Filme>> GetAllAsync() =>
            FilmeServico.GetAllAsync();
    }
}

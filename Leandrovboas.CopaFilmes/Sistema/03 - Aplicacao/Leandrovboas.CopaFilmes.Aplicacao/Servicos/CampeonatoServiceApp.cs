using Leandrovboas.CopaFilmes.Aplicacao.Interfaces;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Dominio.Interfaces.Servico;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Aplicacao.Servicos
{
    public class CampeonatoServiceApp : ICampeonatoServicoApp
    {
        private readonly ICampeonatoServico _servico;
        public CampeonatoServiceApp(ICampeonatoServico servico)
        {
            _servico = servico;
        }

        public Campeonato RealizarCampeonato(List<Filme> listaFilmes) =>
            _servico.RealizarCampeonato(listaFilmes);
    }
}

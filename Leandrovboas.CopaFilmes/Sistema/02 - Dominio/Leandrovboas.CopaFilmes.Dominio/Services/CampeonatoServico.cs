using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Dominio.Interfaces.Servico;
using Leandrovboas.CopaFilmes.Dominio.validate;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Servicos
{
    public class CampeonatoServico : ICampeonatoServico
    {
        public Campeonato RealizarCampeonato(List<Filme> listaFilmes)
        {
            FilmesValidate.ValidarListaFilmesCampeonato(listaFilmes);

            var result = Campeonato.GerarCampeonato(listaFilmes);
            return result;
        }
    }
}

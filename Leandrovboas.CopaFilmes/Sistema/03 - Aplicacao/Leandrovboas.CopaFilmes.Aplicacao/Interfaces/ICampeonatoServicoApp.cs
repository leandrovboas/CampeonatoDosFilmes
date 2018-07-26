using Leandrovboas.CopaFilmes.Dominio.Entity;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Aplicacao.Interfaces
{
    public interface ICampeonatoServicoApp
    {
        Campeonato RealizarCampeonato(List<Filme> listaFilmes);
    }
}

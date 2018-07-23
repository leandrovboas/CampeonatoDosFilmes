using Leandrovboas.CopaFilmes.Dominio.Entity;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Interfaces.Servico
{
    public interface ICampeonatoServico
    {
        Campeonato RealizarCampeonato(List<Filme> listaFilmes);
    }
}

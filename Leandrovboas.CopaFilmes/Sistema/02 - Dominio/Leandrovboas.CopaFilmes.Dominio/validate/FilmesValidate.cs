using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.validate
{
    public static class FilmesValidate
    {
        private const int QUANTIDADE_FILMES_CAMPEOATO = 16;
        private const int QUANTIDADE_FASE_GRUPO = 4;

        public static void ValidarListaFilmesCampeonato(List<Filme> listaFilmes)
        {
            if (listaFilmes == null) throw new ArgumentNullException(nameof(listaFilmes), $"O Parametro {nameof(listaFilmes)} encontra-se null");
            if (listaFilmes.Count != QUANTIDADE_FILMES_CAMPEOATO) throw new ArgumentOutOfRangeException(nameof(listaFilmes), $"Deve conter {QUANTIDADE_FILMES_CAMPEOATO} filmes para iniciar o Campeonato");
        }

        internal static void ValidarListasFaseGrupo(List<Filme> grupoA, List<Filme> grupoB, List<Filme> grupoC, List<Filme> grupoD) {
            if (grupoA == null || grupoA.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(grupoA), $"O Parametro {nameof(grupoA)} esta incorreto");
            if (grupoB == null || grupoB.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(grupoB), $"O Parametro {nameof(grupoB)} esta incorreto");
            if (grupoC == null || grupoC.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(grupoC), $"O Parametro {nameof(grupoC)} esta incorreto");
            if (grupoD == null || grupoD.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(grupoD), $"O Parametro {nameof(grupoA)} esta incorreto");
        }
    }
}

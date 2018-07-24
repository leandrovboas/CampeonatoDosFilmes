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

        internal static void ValidarListasFaseGrupo(FaseDeGrupo faseGrupo)
        {
            if (faseGrupo.GrupoA == null || faseGrupo.GrupoA.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoA), $"O {nameof(faseGrupo.GrupoA)} gerado incorreto");
            if (faseGrupo.GrupoB == null || faseGrupo.GrupoB.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoB), $"O {nameof(faseGrupo.GrupoB)} gerado incorreto");
            if (faseGrupo.GrupoC == null || faseGrupo.GrupoC.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoC), $"O {nameof(faseGrupo.GrupoC)} gerado incorreto");
            if (faseGrupo.GrupoD == null || faseGrupo.GrupoD.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoD), $"O {nameof(faseGrupo.GrupoD)} gerado incorreto");
        }

        internal static void ValidarDisputa(Filme filme1, Filme filme2)
        {
            if (filme1 == null) throw new ArgumentNullException(nameof(filme1), $"O {nameof(filme1)} esta nulo");
            if (filme2 == null) throw new ArgumentNullException(nameof(filme2), $"O {nameof(filme2)} esta nulo");
            if (string.IsNullOrWhiteSpace(filme1.AverageRating)) throw new ArgumentException(nameof(filme1), $"O {nameof(filme1)} não possui nota");
            if (string.IsNullOrWhiteSpace(filme2.AverageRating)) throw new ArgumentException(nameof(filme2), $"O {nameof(filme2)} não possui nota");
        }
    }
}

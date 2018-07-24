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

        internal static void ValidarListasFaseGrupo(FaseDeGrupo faseGrupo) {
            if (faseGrupo.GrupoA == null || faseGrupo.GrupoA.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoA), $"O Parametro {nameof(faseGrupo.GrupoA)} esta incorreto");
            if (faseGrupo.GrupoB == null || faseGrupo.GrupoB.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoB), $"O Parametro {nameof(faseGrupo.GrupoB)} esta incorreto");
            if (faseGrupo.GrupoC == null || faseGrupo.GrupoC.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoC), $"O Parametro {nameof(faseGrupo.GrupoC)} esta incorreto");
            if (faseGrupo.GrupoD == null || faseGrupo.GrupoD.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoD), $"O Parametro {nameof(faseGrupo.GrupoD)} esta incorreto");
        }
    }
}

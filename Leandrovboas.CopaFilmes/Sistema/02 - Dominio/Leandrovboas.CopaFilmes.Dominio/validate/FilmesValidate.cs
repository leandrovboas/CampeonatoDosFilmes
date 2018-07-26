using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.validate
{
    public static class FilmesValidate
    {
        //TODO: Refatorar: Alterar para que cada validação esteja em uma classe
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

        internal static void ValidarFaseEliminatoria(FaseDeGrupo faseDeGrupo)
        {
            if (faseDeGrupo == null) throw new ArgumentNullException(nameof(faseDeGrupo), $"A {nameof(faseDeGrupo)} esta nula");
            if (faseDeGrupo.GrupoA == null) throw new ArgumentNullException(nameof(faseDeGrupo.GrupoA), $"A {nameof(faseDeGrupo.GrupoA)} esta nula");
            if (faseDeGrupo.GrupoB == null) throw new ArgumentNullException(nameof(faseDeGrupo.GrupoB), $"A {nameof(faseDeGrupo.GrupoB)} esta nula");
            if (faseDeGrupo.GrupoC == null) throw new ArgumentNullException(nameof(faseDeGrupo.GrupoC), $"A {nameof(faseDeGrupo.GrupoC)} esta nula");
            if (faseDeGrupo.GrupoD == null) throw new ArgumentNullException(nameof(faseDeGrupo.GrupoD), $"A {nameof(faseDeGrupo.GrupoD)} esta nula");
        }

        internal static void ValidarFaseSemiFinal(FaseEliminatoria faseEliminatoria)
        {
            if (faseEliminatoria == null) throw new ArgumentNullException(nameof(faseEliminatoria), $"A {nameof(faseEliminatoria)} esta nula");
            if (faseEliminatoria.PrimeiraDisputa == null) throw new ArgumentNullException(nameof(faseEliminatoria.PrimeiraDisputa), $"A {nameof(faseEliminatoria.PrimeiraDisputa)} esta nula");
            if (faseEliminatoria.SegundaDisputa == null) throw new ArgumentNullException(nameof(faseEliminatoria.SegundaDisputa), $"A {nameof(faseEliminatoria.SegundaDisputa)} esta nula");
            if (faseEliminatoria.TerceiraDisputa == null) throw new ArgumentNullException(nameof(faseEliminatoria.TerceiraDisputa), $"A {nameof(faseEliminatoria.TerceiraDisputa)} esta nula");
            if (faseEliminatoria.QuartaDisputa == null) throw new ArgumentNullException(nameof(faseEliminatoria.QuartaDisputa), $"A {nameof(faseEliminatoria.QuartaDisputa)} esta nula");
        }

        internal static void ValidarFaseFinal(FaseSemiFinal FaseSemiFinal)
        {
            if (FaseSemiFinal == null) throw new ArgumentNullException(nameof(FaseSemiFinal), $"A {nameof(FaseSemiFinal)} esta nula");
            if (FaseSemiFinal.PrimeiraDisputa == null) throw new ArgumentNullException(nameof(FaseSemiFinal.PrimeiraDisputa), $"A {nameof(FaseSemiFinal.PrimeiraDisputa)} esta nula");
            if (FaseSemiFinal.SegundaDisputa == null) throw new ArgumentNullException(nameof(FaseSemiFinal.SegundaDisputa), $"A {nameof(FaseSemiFinal.SegundaDisputa)} esta nula");
        }
    }
}

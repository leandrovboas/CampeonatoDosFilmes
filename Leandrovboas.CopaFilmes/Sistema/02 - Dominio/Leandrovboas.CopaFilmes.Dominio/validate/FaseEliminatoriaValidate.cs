using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public class FaseEliminatoriaValidate
    {
        private const int QUANTIDADE_FASE_GRUPO = 4;

        internal static void Validar(List<Filme> GrupoA, List<Filme> GrupoB, List<Filme> GrupoC, List<Filme> GrupoD)
        {
            if (GrupoA == null) throw new ArgumentNullException(nameof(GrupoA), $"A {nameof(GrupoA)} esta nula");
            if (GrupoB == null) throw new ArgumentNullException(nameof(GrupoB), $"A {nameof(GrupoB)} esta nula");
            if (GrupoC == null) throw new ArgumentNullException(nameof(GrupoC), $"A {nameof(GrupoC)} esta nula");
            if (GrupoD == null) throw new ArgumentNullException(nameof(GrupoD), $"A {nameof(GrupoD)} esta nula");

            if (GrupoA.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(GrupoA), $"O {nameof(GrupoA)} gerado incorreto");
            if (GrupoB.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(GrupoB), $"O {nameof(GrupoB)} gerado incorreto");
            if (GrupoC.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(GrupoC), $"O {nameof(GrupoC)} gerado incorreto");
            if (GrupoD.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(GrupoD), $"O {nameof(GrupoD)} gerado incorreto");
        }
    }
}

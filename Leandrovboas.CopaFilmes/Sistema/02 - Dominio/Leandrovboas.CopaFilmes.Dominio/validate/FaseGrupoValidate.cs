using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public class FaseGrupoValidate
    {
        private const int QUANTIDADE_FASE_GRUPO = 4;

        internal static void Validar(FaseDeGrupo faseGrupo)
        {
            if (faseGrupo.GrupoA == null || faseGrupo.GrupoA.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoA), $"O {nameof(faseGrupo.GrupoA)} gerado incorreto");
            if (faseGrupo.GrupoB == null || faseGrupo.GrupoB.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoB), $"O {nameof(faseGrupo.GrupoB)} gerado incorreto");
            if (faseGrupo.GrupoC == null || faseGrupo.GrupoC.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoC), $"O {nameof(faseGrupo.GrupoC)} gerado incorreto");
            if (faseGrupo.GrupoD == null || faseGrupo.GrupoD.Count != QUANTIDADE_FASE_GRUPO) throw new ArgumentException(nameof(faseGrupo.GrupoD), $"O {nameof(faseGrupo.GrupoD)} gerado incorreto");
        }
    }
}

using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public class DisputaValidate
    {
        internal static void Validar(Filme filme1, Filme filme2)
        {
            if (filme1 == null) throw new ArgumentNullException(nameof(filme1), $"O {nameof(filme1)} esta nulo");
            if (filme2 == null) throw new ArgumentNullException(nameof(filme2), $"O {nameof(filme2)} esta nulo");
            if (string.IsNullOrWhiteSpace(filme1.AverageRating)) throw new ArgumentException(nameof(filme1), $"O {nameof(filme1)} não possui nota");
            if (string.IsNullOrWhiteSpace(filme2.AverageRating)) throw new ArgumentException(nameof(filme2), $"O {nameof(filme2)} não possui nota");
        }
    }
}

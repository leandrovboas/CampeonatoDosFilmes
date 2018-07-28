using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public class FaseFinalValidate
    {
        internal static void Validar(Disputa PrimeiraDisputa, Disputa SegundaDisputa)
        {
            if (PrimeiraDisputa == null) throw new ArgumentNullException(nameof(PrimeiraDisputa), $"A {nameof(PrimeiraDisputa)} esta nula");
            if (SegundaDisputa == null) throw new ArgumentNullException(nameof(SegundaDisputa), $"A {nameof(SegundaDisputa)} esta nula");
        }
    }
}

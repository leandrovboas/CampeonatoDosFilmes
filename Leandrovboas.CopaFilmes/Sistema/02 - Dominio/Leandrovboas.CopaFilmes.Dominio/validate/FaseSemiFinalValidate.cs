using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public class FaseSemiFinalValidate
    {
        internal static void Validar(Disputa resultadoPrimeiraDisputa, Disputa resultadoSegundaDisputa, Disputa resultadoTerceiraDisputa, Disputa resultadoQuartaDisputa)
        {
            if (resultadoPrimeiraDisputa == null) throw new ArgumentNullException(nameof(resultadoPrimeiraDisputa), $"A {nameof(resultadoPrimeiraDisputa)} esta nula");
            if (resultadoSegundaDisputa  == null) throw new ArgumentNullException(nameof(resultadoSegundaDisputa),  $"A {nameof(resultadoSegundaDisputa)} esta nula");
            if (resultadoTerceiraDisputa == null) throw new ArgumentNullException(nameof(resultadoTerceiraDisputa), $"A {nameof(resultadoTerceiraDisputa)} esta nula");
            if (resultadoQuartaDisputa   == null) throw new ArgumentNullException(nameof(resultadoQuartaDisputa),   $"A {nameof(resultadoQuartaDisputa)} esta nula");
        }
    }
}

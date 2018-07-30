using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public class FaseSemiFinalValidate
    {
        internal static void Validar(Disputa resultadoPrimeiraDisputa, Disputa resultadoSegundaDisputa, Disputa resultadoTerceiraDisputa, Disputa resultadoQuartaDisputa)
        {
            if (resultadoPrimeiraDisputa == null) throw new ArgumentNullException(nameof(resultadoPrimeiraDisputa), $"O {nameof(resultadoPrimeiraDisputa)} esta nulo");
            if (resultadoSegundaDisputa  == null) throw new ArgumentNullException(nameof(resultadoSegundaDisputa),  $"O {nameof(resultadoSegundaDisputa)} esta nulo");
            if (resultadoTerceiraDisputa == null) throw new ArgumentNullException(nameof(resultadoTerceiraDisputa), $"O {nameof(resultadoTerceiraDisputa)} esta nulo");
            if (resultadoQuartaDisputa   == null) throw new ArgumentNullException(nameof(resultadoQuartaDisputa),   $"O {nameof(resultadoQuartaDisputa)} esta nulo");

            if (resultadoPrimeiraDisputa.Perdedor == null) throw new ArgumentNullException(nameof(resultadoPrimeiraDisputa.Perdedor), $"O {nameof(resultadoPrimeiraDisputa.Perdedor)} esta nulo");
            if (resultadoPrimeiraDisputa.Vencedor == null) throw new ArgumentNullException(nameof(resultadoPrimeiraDisputa.Vencedor), $"O {nameof(resultadoPrimeiraDisputa.Vencedor)} esta nulo");
            if (resultadoSegundaDisputa.Perdedor == null) throw new ArgumentNullException(nameof(resultadoSegundaDisputa.Perdedor), $"O {nameof(resultadoSegundaDisputa.Perdedor)} esta nulo");
            if (resultadoSegundaDisputa.Vencedor == null) throw new ArgumentNullException(nameof(resultadoSegundaDisputa.Vencedor), $"O {nameof(resultadoSegundaDisputa.Vencedor)} esta nulo");
            if (resultadoTerceiraDisputa.Perdedor == null) throw new ArgumentNullException(nameof(resultadoTerceiraDisputa.Perdedor), $"O {nameof(resultadoTerceiraDisputa.Perdedor)} esta nulo");
            if (resultadoTerceiraDisputa.Vencedor == null) throw new ArgumentNullException(nameof(resultadoTerceiraDisputa.Vencedor), $"O {nameof(resultadoTerceiraDisputa.Vencedor)} esta nulo");
            if (resultadoQuartaDisputa.Perdedor == null) throw new ArgumentNullException(nameof(resultadoQuartaDisputa.Perdedor), $"O {nameof(resultadoQuartaDisputa.Perdedor)} esta nulo");
            if (resultadoQuartaDisputa.Vencedor == null) throw new ArgumentNullException(nameof(resultadoQuartaDisputa.Vencedor), $"O {nameof(resultadoQuartaDisputa.Vencedor)} esta nulo");
        }
    }
}

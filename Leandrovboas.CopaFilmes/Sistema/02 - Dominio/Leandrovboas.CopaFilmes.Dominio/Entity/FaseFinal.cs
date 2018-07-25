using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseFinal
    {
        #region Construtor
        public FaseFinal(FaseSemiFinal faseSemiFinal)
        {
            //FilmesValidate.ValidarFaseSemiFinal(faseEliminatoria);

            if (faseSemiFinal == null) throw new ArgumentNullException(nameof(faseSemiFinal), $"A {nameof(faseSemiFinal)} esta nula");

            DisputaFinal = Disputa.GerarDisputa(faseSemiFinal.PrimeiraDisputa.Vencedor, faseSemiFinal.SegundaDisputa.Vencedor);
        }
        #endregion

        #region Propriedades
        public Disputa DisputaFinal { get; private set; }
        #endregion

        #region MetodosPublicos
        public static FaseFinal GerarFaseFinal(FaseSemiFinal faseSemiFinal) =>
            new FaseFinal(faseSemiFinal);
        #endregion
    }
}
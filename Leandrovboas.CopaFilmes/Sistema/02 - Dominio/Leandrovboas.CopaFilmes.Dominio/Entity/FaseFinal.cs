using Leandrovboas.CopaFilmes.Dominio.validate;
using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseFinal
    {
        #region Construtor
        public FaseFinal(FaseSemiFinal faseSemiFinal)
        {
            FilmesValidate.ValidarFaseFinal(faseSemiFinal);

            if (faseSemiFinal == null) throw new ArgumentNullException(nameof(faseSemiFinal), $"A {nameof(faseSemiFinal)} esta nula");

            DisputaFinal = Disputa.GerarDisputa(faseSemiFinal.PrimeiraDisputa.Vencedor, faseSemiFinal.SegundaDisputa.Vencedor);
            GerarClassificacao(faseSemiFinal);
        }
        #endregion

        #region Propriedades
        private Disputa DisputaFinal { get; }
        public Filme PrimeiroLugar { get; private set; }
        public Filme SeguntoLugar { get; private set; }
        public Filme TerceiroLugar { get; private set; }
        #endregion

        #region MetodosPublicos
        public static FaseFinal GerarFaseFinal(FaseSemiFinal faseSemiFinal) =>
            new FaseFinal(faseSemiFinal);
        #endregion

        #region MetodosPrivados
        private void GerarClassificacao(FaseSemiFinal faseSemiFinal)
        {
            PrimeiroLugar = DisputaFinal.Vencedor;
            SeguntoLugar = DisputaFinal.Perdedor;
            TerceiroLugar = faseSemiFinal.PrimeiraDisputa.Vencedor == PrimeiroLugar
                ? faseSemiFinal.PrimeiraDisputa.Perdedor
                : faseSemiFinal.SegundaDisputa.Perdedor;
        } 
        #endregion
    }
}
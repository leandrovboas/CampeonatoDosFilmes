using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseFinal
    {
        #region Construtor
        public FaseFinal(Disputa primeiraDisputa, Disputa segundaDisputa)
        {
            FaseFinalValidate.Validar(primeiraDisputa, segundaDisputa);

            DisputaFinal = Disputa.GerarDisputa(primeiraDisputa.Vencedor, segundaDisputa.Vencedor);
            GerarClassificacao(primeiraDisputa, segundaDisputa, DisputaFinal);
        }
        #endregion

        #region Propriedades
        private Disputa DisputaFinal { get; }
        public Filme PrimeiroLugar { get; private set; }
        public Filme SeguntoLugar { get; private set; }
        public Filme TerceiroLugar { get; private set; }
        #endregion

        #region MetodosPublicos
        public static FaseFinal GerarFaseFinal(Disputa primeiraDisputa, Disputa SegundaDisputa) =>
            new FaseFinal(primeiraDisputa, SegundaDisputa);
        #endregion

        #region MetodosPrivados
        private void GerarClassificacao(Disputa primeiraDisputa, Disputa segundaDisputa, Disputa DisputaFinal)
        {
            PrimeiroLugar = DisputaFinal.Vencedor;
            SeguntoLugar = DisputaFinal.Perdedor;
            TerceiroLugar = primeiraDisputa.Vencedor == PrimeiroLugar
                ? primeiraDisputa.Perdedor
                : segundaDisputa.Perdedor;
        } 
        #endregion
    }
}
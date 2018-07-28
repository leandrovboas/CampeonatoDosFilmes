namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseSemiFinal
    {
        #region Construtor
        public FaseSemiFinal(Disputa resultadoPrimeiraDisputa, Disputa resultadoSegundaDisputa, Disputa resultadoTerceiraDisputa, Disputa resultadoQuartaDisputa)
        {
            FaseSemiFinalValidate.Validar(resultadoPrimeiraDisputa, resultadoSegundaDisputa, resultadoTerceiraDisputa, resultadoQuartaDisputa);

            PrimeiraDisputa = Disputa.GerarDisputa(resultadoPrimeiraDisputa.Vencedor, resultadoSegundaDisputa.Vencedor);
            SegundaDisputa = Disputa.GerarDisputa(resultadoTerceiraDisputa.Vencedor, resultadoQuartaDisputa.Vencedor);
        }
        #endregion

        #region Propriedades
        public Disputa PrimeiraDisputa { get; private set; }
        public Disputa SegundaDisputa { get; private set; }
        #endregion

        #region MetodosPublicos
        public static FaseSemiFinal GerarFaseSemiFinal(Disputa resultadoPrimeiraDisputa, Disputa resultadoSegundaDisputa, Disputa resultadoTerceiraDisputa, Disputa resultadoQuartaDisputa) =>
            new FaseSemiFinal(resultadoPrimeiraDisputa, resultadoSegundaDisputa, resultadoTerceiraDisputa, resultadoQuartaDisputa);
        #endregion
    }
}
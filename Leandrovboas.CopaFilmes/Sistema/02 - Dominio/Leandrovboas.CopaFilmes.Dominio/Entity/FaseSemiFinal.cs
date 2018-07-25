using Leandrovboas.CopaFilmes.Dominio.validate;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseSemiFinal
    {
        #region Construtor
        public FaseSemiFinal(FaseEliminatoria faseEliminatoria)
        {
            FilmesValidate.ValidarFaseSemiFinal(faseEliminatoria);

            PrimeiraDisputa = Disputa.GerarDisputa(faseEliminatoria.PrimeiraDisputa.Vencedor, faseEliminatoria.SegundaDisputa.Vencedor);
            SegundaDisputa = Disputa.GerarDisputa(faseEliminatoria.TerceiraDisputa.Vencedor, faseEliminatoria.QuartaDisputa.Vencedor);
        }
        #endregion

        #region Propriedades
        public Disputa PrimeiraDisputa { get; private set; }
        public Disputa SegundaDisputa { get; private set; }
        #endregion

        #region MetodosPublicos
        public static FaseSemiFinal GerarFaseSemiFinal(FaseEliminatoria faseEliminatoria) =>
            new FaseSemiFinal(faseEliminatoria);
        #endregion
    }
}
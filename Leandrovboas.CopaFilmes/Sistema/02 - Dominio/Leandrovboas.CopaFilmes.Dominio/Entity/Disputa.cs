namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Disputa
    {
        protected Disputa(Filme filme1, Filme filme2)
        {
            Vencedor = filme1.AvageRatingDecimal > filme2.AvageRatingDecimal ? filme1 : filme2;
            Perdedor = filme1.AvageRatingDecimal < filme2.AvageRatingDecimal ? filme1 : filme2;
        }

        public Filme Vencedor { get; }
        public Filme Perdedor { get; }

        public static Disputa GerarDisputa(Filme filme1, Filme filme2) =>
            new Disputa(filme1, filme2);
    }
}
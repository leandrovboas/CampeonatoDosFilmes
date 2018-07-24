using Leandrovboas.CopaFilmes.Dominio.validate;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Disputa
    {
        protected Disputa(Filme filme1, Filme filme2)
        {
            FilmesValidate.ValidarDisputa(filme1, filme2);

            Vencedor = GerarVencedor(filme1, filme2);
            Perdedor = GerarPerdedor(filme1, filme2);
        }

        private static Filme GerarVencedor(Filme filme1, Filme filme2)
        {
            if (filme1.SetAvageRatingDecimal == filme2.SetAvageRatingDecimal)
            {
                var filmes = new List<Filme> { filme1, filme2 };
                return filmes.OrderBy(x => x.PrimaryTitle).First();
            }
            return filme1.SetAvageRatingDecimal > filme2.SetAvageRatingDecimal ? filme1 : filme2;
        }

        private static Filme GerarPerdedor(Filme filme1, Filme filme2)
        {
            if (filme1.SetAvageRatingDecimal == filme2.SetAvageRatingDecimal)
            {
                var filmes = new List<Filme> { filme1, filme2 };
                return filmes.OrderBy(x => x.PrimaryTitle).Last();
            }
            return filme1.SetAvageRatingDecimal < filme2.SetAvageRatingDecimal ? filme1 : filme2;
        }

        public Filme Vencedor { get; }
        public Filme Perdedor { get; }

        public static Disputa GerarDisputa(Filme filme1, Filme filme2) =>
            new Disputa(filme1, filme2);
    }
}
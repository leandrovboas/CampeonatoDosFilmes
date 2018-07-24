using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Filme
    {
        public string Id { get; set; }
        public string PrimaryTitle { get; set; }
        public int Year { get; set; }
        public string AverageRating { get; set; }
        private decimal avageRatingDecimal;

        public decimal AvageRatingDecimal
        {
            get => avageRatingDecimal;
            private set => Convert.ToDecimal(AverageRating);
        }
    }
}

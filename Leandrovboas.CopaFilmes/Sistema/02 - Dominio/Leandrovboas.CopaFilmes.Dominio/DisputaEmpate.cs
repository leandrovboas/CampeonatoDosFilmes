using Leandrovboas.CopaFilmes.Dominio.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public class DisputaEmpate
    {
        private readonly List<Filme> Filmes;

        public DisputaEmpate(Filme filme1, Filme filme2)
        {
            Filmes = new List<Filme>
            {
                filme1, filme2
            };
        }
        public Filme EmpatePerdedor => Filmes.OrderBy(x => x.PrimaryTitle).Last();

        public Filme EmpateVencedor => Filmes.OrderBy(x => x.PrimaryTitle).First();
    }
}

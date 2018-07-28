using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseEliminatoria
    {
        #region Construtor
        protected FaseEliminatoria(List<Filme> GrupoA, List<Filme> GrupoB, List<Filme> GrupoC, List<Filme> GrupoD)
        {
            FaseEliminatoriaValidate.Validar(GrupoA, GrupoB, GrupoC, GrupoD);
            PrimeiraDisputa = Disputa.GerarDisputa(GrupoA?[0], GrupoB?[1]);
            SegundaDisputa = Disputa.GerarDisputa(GrupoB?[0], GrupoA?[1]);
            TerceiraDisputa = Disputa.GerarDisputa(GrupoC?[0], GrupoD?[1]);
            QuartaDisputa = Disputa.GerarDisputa(GrupoD?[0], GrupoC?[1]);
        }
        #endregion

        #region Propriedades
        public Disputa PrimeiraDisputa { get; private set; }
        public Disputa SegundaDisputa { get; private set; }
        public Disputa TerceiraDisputa { get; private set; }
        public Disputa QuartaDisputa { get; private set; } 
        #endregion

        #region MetodosPublicos
        public static FaseEliminatoria GerarFaseEliminatoria( List<Filme> GrupoA, List<Filme> GrupoB, List<Filme> GrupoC, List<Filme> GrupoD) =>
            new FaseEliminatoria(GrupoA, GrupoB, GrupoC, GrupoD);
        #endregion
    }
}
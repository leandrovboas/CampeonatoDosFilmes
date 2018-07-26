using Leandrovboas.CopaFilmes.Dominio.validate;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseEliminatoria
    {
        #region Construtor
        protected FaseEliminatoria(FaseDeGrupo faseDeGrupo)
        {
            FilmesValidate.ValidarFaseEliminatoria(faseDeGrupo);
            PrimeiraDisputa = Disputa.GerarDisputa(faseDeGrupo.GrupoA?[0], faseDeGrupo.GrupoB?[1]);
            SegundaDisputa = Disputa.GerarDisputa(faseDeGrupo.GrupoB?[0], faseDeGrupo.GrupoA?[1]);
            TerceiraDisputa = Disputa.GerarDisputa(faseDeGrupo.GrupoC?[0], faseDeGrupo.GrupoD?[1]);
            QuartaDisputa = Disputa.GerarDisputa(faseDeGrupo.GrupoD?[0], faseDeGrupo.GrupoC?[1]);
        } 
        #endregion

        #region Propriedades
        public Disputa PrimeiraDisputa { get; private set; }
        public Disputa SegundaDisputa { get; private set; }
        public Disputa TerceiraDisputa { get; private set; }
        public Disputa QuartaDisputa { get; private set; } 
        #endregion

        #region MetodosPublicos
        public static FaseEliminatoria GerarFaseEliminatoria(FaseDeGrupo faseDeGrupo) =>
            new FaseEliminatoria(faseDeGrupo);
        #endregion
    }
}
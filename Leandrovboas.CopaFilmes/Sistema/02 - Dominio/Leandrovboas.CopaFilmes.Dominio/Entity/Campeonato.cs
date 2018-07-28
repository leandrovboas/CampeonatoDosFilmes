using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Campeonato
    {
        #region Construtor
        protected Campeonato(List<Filme> listaFilmes)
        {
            FilmesValidate.Validar(listaFilmes);

            FaseDeGrupo         = FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);
            FaseEliminatoria    = FaseEliminatoria.GerarFaseEliminatoria(FaseDeGrupo.GrupoA, FaseDeGrupo.GrupoB, FaseDeGrupo.GrupoC, FaseDeGrupo.GrupoD);
            FaseSemiFinal       = FaseSemiFinal.GerarFaseSemiFinal(FaseEliminatoria.PrimeiraDisputa, FaseEliminatoria.SegundaDisputa, FaseEliminatoria.TerceiraDisputa, FaseEliminatoria.QuartaDisputa);
            FaseFinal           = FaseFinal.GerarFaseFinal(FaseSemiFinal.PrimeiraDisputa, FaseSemiFinal.SegundaDisputa);
        }
        #endregion

        #region Propriedades
        public FaseDeGrupo FaseDeGrupo { get; set; }
        public FaseEliminatoria FaseEliminatoria { get; set; }
        public FaseSemiFinal FaseSemiFinal { get; set; }
        public FaseFinal FaseFinal { get; set; }
        #endregion

        #region MetodosPublicos
        public static Campeonato GerarCampeonato(List<Filme> listaFilmes) =>
            new Campeonato(listaFilmes); 
        #endregion



        //TODO: Testar chain-of-responsibility https://www.dofactory.com/net/chain-of-responsibility-design-pattern
    }
}

using Leandrovboas.CopaFilmes.Dominio.validate;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Campeonato
    {
        #region Construtor
        protected Campeonato(List<Filme> listaFilmes)
        {
            FilmesValidate.ValidarListaFilmesCampeonato(listaFilmes);

            FaseDeGrupo = FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);
            FaseEliminatoria = FaseEliminatoria.GerarFaseEliminatoria(FaseDeGrupo);
            FaseSemiFinal = FaseSemiFinal.GerarFaseSemiFinal(FaseEliminatoria);
            FaseFinal = FaseFinal.GerarFaseFinal(FaseSemiFinal);
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

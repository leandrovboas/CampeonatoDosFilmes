using Leandrovboas.CopaFilmes.Dominio.Extension;
using Leandrovboas.CopaFilmes.Dominio.validate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseDeGrupo
    {
        #region Propriedades
        private static List<Filme> ListaFilmes;
        public List<Filme> GrupoA { get; }
        public List<Filme> GrupoB { get; }
        public List<Filme> GrupoC { get; }
        public List<Filme> GrupoD { get; } 
        #endregion

        #region Construtor
        protected FaseDeGrupo(List<Filme> listaFilmes)
        {
            FilmesValidate.ValidarListaFilmesCampeonato(listaFilmes);

            ListaFilmes = listaFilmes;
            GrupoA = GerarGrupos(ref ListaFilmes);
            GrupoB = GerarGrupos(ref ListaFilmes);
            GrupoC = GerarGrupos(ref ListaFilmes);
            GrupoD = GerarGrupos(ref ListaFilmes);

            if (ListaFilmes.Count != 0) throw new ApplicationException("Ocorreu um problema na criação da faze de grupo");

            FilmesValidate.ValidarListasFaseGrupo(this);
        } 
        #endregion

        #region MetodosPublicos
        public static FaseDeGrupo GerarFaseDeGrupo(List<Filme> listaFilmes) =>
            new FaseDeGrupo(listaFilmes); 
        #endregion

        #region MetodosPrivados
        private static List<Filme> GerarGrupos(ref List<Filme> listaFilmes)
        {
            var result = listaFilmes.PickRandom(4).ToList();
            listaFilmes.RemoveItens(result);
            result = result.OrdenarFormaGenerico(SortDirection.Ascending, ObjectUtilities.GetPropertyName(() => new Filme().PrimaryTitle));
            result = result.OrdenarFormaGenerico(SortDirection.Descending, ObjectUtilities.GetPropertyName(() => new Filme().SetAvageRatingDecimal));
            return result;
        }
        #endregion
    }
}
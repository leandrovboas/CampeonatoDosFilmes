using Leandrovboas.CopaFilmes.Dominio.Extension;
using Leandrovboas.CopaFilmes.Dominio.validate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseDeGrupo
    {
        private static List<Filme> ListaFilmes;
        public List<Filme> GrupoA { get; }
        public List<Filme> GrupoB { get; }
        public List<Filme> GrupoC { get; }
        public List<Filme> GrupoD { get; }

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

        public static FaseDeGrupo GerarFaseDeGrupo(List<Filme> listaFilmes) =>
            new FaseDeGrupo(listaFilmes);

        private static List<Filme> GerarGrupos(ref List<Filme> listaFilmes)
        {
            var result = listaFilmes.PickRandom(4).ToList();
            listaFilmes.RemoveItens(result);
            return OrdenarFaseDeGrupo.Ordenar(result);
        }
    }
}
using Leandrovboas.CopaFilmes.Dominio.Extension;
using Leandrovboas.CopaFilmes.Dominio.validate;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class FaseDeGrupo
    {
        public List<Filme> GrupoA { get; }
        public List<Filme> GrupoB { get; }
        public List<Filme> GrupoC { get; }
        public List<Filme> GrupoD { get; }

        protected FaseDeGrupo(List<Filme> grupoA, List<Filme> grupoB, List<Filme> grupoC, List<Filme> grupoD)
        {
            FilmesValidate.ValidarListasFaseGrupo(grupoA, grupoB, grupoC, grupoD);

            GrupoA = grupoA;
            GrupoA = grupoB;
            GrupoA = grupoC;
            GrupoA = grupoD;
        }

        public static FaseDeGrupo GerarFaseDeGrupo(List<Filme> listaFilmes)
        {
            FilmesValidate.ValidarListaFilmesCampeonato(listaFilmes);

            var result = new FaseDeGrupo(GerarGrupos(ref listaFilmes), GerarGrupos(ref listaFilmes), GerarGrupos(ref listaFilmes), GerarGrupos(ref listaFilmes));
            if (listaFilmes.Count != 0) throw new ApplicationException("Ocorreu um problema na criação da faze de grupo");
            return result;
        }

        private static List<Filme> GerarGrupos(ref List<Filme> listaFilmes)
        {
            var result = listaFilmes.PickRandom(4).ToList();
            RemoveItens(ref listaFilmes, result);
            return result;
        }

        private static void RemoveItens(ref List<Filme> listaFilmes, List<Filme> grupoA) {
            foreach (var item in grupoA)
            {
                listaFilmes.Remove(item);
            }
        }
    }
}
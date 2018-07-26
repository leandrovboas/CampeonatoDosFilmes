using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public static class OrdenarFaseDeGrupo
    {
        //TODO: Refatorar: Alterar a classe para um ordenador passar a lista para o construtor e retornas a ordenacao em propriedade
        //public static List<Filme> Ordenar(List<Filme> listaFilmes)
        //{
        //   if (listaFilmes == null) throw new ArgumentException(nameof(listaFilmes), $"O Parametro {nameof(listaFilmes)} esta invalido");

        //    var ordenarAlfabetica = OrdenarPorOrdemAlfabetica(listaFilmes);
        //    return OrdenarPorNota(ordenarAlfabetica);
        //}

        //private static List<Filme> OrdenarPorNota(List<Filme> listaFilmes) =>
        //    listaFilmes.OrderByDescending(x => x.SetAvageRatingDecimal).ToList();

        //private static List<Filme> OrdenarPorOrdemAlfabetica(List<Filme> listaFilmes) =>
        //    listaFilmes.OrderBy(x => x.PrimaryTitle).ToList();
    }
}

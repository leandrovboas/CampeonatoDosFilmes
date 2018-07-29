using System;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio.Extension
{
    public static class EnumerableExtension
    {
        /// <summary>
        /// Escolhe de forma aleatoria um item dentro de uma lista
        /// </summary>
        /// <typeparam name="T">Tipo da lista</typeparam>
        /// <param name="source">Lista para realizar a operacao</param>
        /// <returns>Um item aleatoria da lista</returns>
        public static T EscolhaAleataria<T>(this IEnumerable<T> source) =>
            source.EscolhaAleataria(1).Single();

        /// <summary>
        /// Escolhe de forma aleatoria algums itens dentro de uma lista
        /// </summary>
        /// <typeparam name="T">Tipo da lista</typeparam>
        /// <param name="source">Lista para realizar a operacao</param>
        /// <param name="count">Quantidade de itens que deve ser retornado</param>
        /// <returns>Uma lista com a quantidade de itens solicitado</returns>
        public static IEnumerable<T> EscolhaAleataria<T>(this IEnumerable<T> source, int count) =>
            source.Embaralhar().Take(count);

        /// <summary>
        /// Mistura os itens dendro da lista
        /// </summary>
        /// <typeparam name="T">Tipo da lista</typeparam>
        /// <param name="source">Lista para ser embaralhada</param>
        /// <returns>Lista com a ordem misturada</returns>
        public static IEnumerable<T> Embaralhar<T>(this IEnumerable<T> source) =>
            source.OrderBy(x => Guid.NewGuid());
    }
}

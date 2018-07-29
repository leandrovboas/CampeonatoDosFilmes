using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Leandrovboas.CopaFilmes.Dominio.Extension
{
    public static class ListExtension
    {
        public static void RemoveItens<T>(this List<T> source, List<T> Itens)
        {
            foreach (var item in Itens)
            {
                source.Remove(item);
            }
        }

        /// <summary>
        /// Ordena lista pela propriedade informada e no sentido informado
        /// </summary>
        /// <typeparam name="T">Tipo da lista</typeparam>
        /// <param name="source">Lista para ordenar</param>
        /// <param name="DirecaoOrdenacao">SortDirection.Ascending\SortDirection.Descending</param>
        /// <param name="propriedadeAOrdenar">Proprienade que sera utilizada para ordenacao</param>
        /// <returns></returns>
        public static List<T> OrdenarFormaGenerica<T>(this List<T> source, SortDirection DirecaoOrdenacao, string propriedadeAOrdenar)
        {
            if (!string.IsNullOrWhiteSpace(propriedadeAOrdenar) && source != null && source.Count > 0)
            {
                var t = source[0].GetType();

                source = DirecaoOrdenacao == SortDirection.Ascending
                    ? source.OrderBy(
                        x => t.InvokeMember(
                            propriedadeAOrdenar,
                            System.Reflection.BindingFlags.GetProperty,
                            null,
                            x,
                            null)
                    ).ToList()
                    : source.OrderByDescending(
                        x => t.InvokeMember(
                            propriedadeAOrdenar
                            , System.Reflection.BindingFlags.GetProperty
                            , null
                            , x
                            , null
                        )
                    ).ToList();
            }

            return source;
        }
    }
}

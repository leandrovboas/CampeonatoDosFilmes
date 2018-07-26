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

        public static List<T> OrdenarFormaGenerico<T>(this List<T> source, SortDirection DirecaoOrdenacao, string propriedadeAOrdenar)
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

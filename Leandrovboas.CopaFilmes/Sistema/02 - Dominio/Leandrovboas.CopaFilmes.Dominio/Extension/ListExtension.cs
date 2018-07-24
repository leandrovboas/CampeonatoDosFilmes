using System.Collections.Generic;

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
    }
}

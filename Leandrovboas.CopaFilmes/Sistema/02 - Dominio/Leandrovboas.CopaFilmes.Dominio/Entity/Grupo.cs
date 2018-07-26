using Leandrovboas.CopaFilmes.Dominio.Extension;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Grupo
    {
        public static List<Filme> GerarGrupos(List<Filme> listaFilmes)
        {
            var result = listaFilmes.PickRandom(4).ToList();
            result.OrdenarFormaGenerico(SortDirection.Ascending, ObjectUtilities.GetPropertyName(() => new Filme().PrimaryTitle));
            result.OrdenarFormaGenerico(SortDirection.Descending, ObjectUtilities.GetPropertyName(() => new Filme().SetAvageRatingDecimal));
            return result;
        }
    }
}

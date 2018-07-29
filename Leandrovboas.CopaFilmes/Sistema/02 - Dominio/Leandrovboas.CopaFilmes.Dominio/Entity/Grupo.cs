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
            var result = listaFilmes.EscolhaAleataria(4).ToList();
            result.OrdenarFormaGenerica(SortDirection.Ascending, ObjectUtilities.GetPropertyName(() => new Filme().PrimaryTitle));
            result.OrdenarFormaGenerica(SortDirection.Descending, ObjectUtilities.GetPropertyName(() => new Filme().SetAvageRatingDecimal));
            return result;
        }
    }
}

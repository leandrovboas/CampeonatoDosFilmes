using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Dominio.Extension;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Leandrovboas.CopaFilmes.Dominio.Tests
{
    [TestClass()]
    public class OrdenarFaseDeGrupoTests
    {
        private List<Filme> listaFilmes;

        [TestInitialize]
        public void Inicializar() => listaFilmes = new List<Filme>
            {
                new Filme{ Id = "3", PrimaryTitle = "BFilme3", AverageRating = "8.0", Year = 2018},
                new Filme{ Id = "1", PrimaryTitle = "AFilme1", AverageRating = "10.0", Year = 2018},
                new Filme{ Id = "4", PrimaryTitle = "BFilme4", AverageRating = "7.0", Year = 2018},
                new Filme{ Id = "2", PrimaryTitle = "AFilme2", AverageRating = "8.0", Year = 2018}
            };

        [TestMethod()]
        public void OrdenarTest()
        {
            var listaEsperada = listaFilmes.OrderBy(x => x.Id).ToList();
            listaFilmes = listaFilmes.OrdenarFormaGenerico(SortDirection.Descending, ObjectUtilities.GetPropertyName(() => new Filme().SetAvageRatingDecimal));
            listaFilmes = listaFilmes.OrdenarFormaGenerico(SortDirection.Ascending, ObjectUtilities.GetPropertyName(() => new Filme().PrimaryTitle));
            CollectionAssert.AreEqual(listaEsperada, listaFilmes);
        }
    }
}
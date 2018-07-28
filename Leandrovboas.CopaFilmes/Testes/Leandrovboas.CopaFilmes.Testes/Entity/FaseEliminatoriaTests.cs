using Leandrovboas.CopaFilmes.Dominio.Extension;
using Leandrovboas.CopaFilmes.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI.WebControls;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class FaseEliminatoriaTests
    {
        private List<Filme> listaFilmes;

        [TestInitialize]
        public void Inicializar() => listaFilmes = CriacaoListaFilmes.Criar();

        [TestMethod()]
        public void GerarFaseEliminatoriaTest()
        {
            var GrupoA = GerarGrupo();
            var GrupoB = GerarGrupo();
            var GrupoC = GerarGrupo();
            var GrupoD = GerarGrupo();

            var disputa1 = Disputa.GerarDisputa(GrupoA[0], GrupoB[1]);
            var disputa2 = Disputa.GerarDisputa(GrupoB[0], GrupoA[1]);
            var disputa4 = Disputa.GerarDisputa(GrupoD[0], GrupoC[1]);
            var disputa3 = Disputa.GerarDisputa(GrupoC[0], GrupoD[1]);

            var result = FaseEliminatoria.GerarFaseEliminatoria(GrupoA, GrupoB, GrupoC, GrupoD);

            Assert.AreEqual(disputa1.Perdedor, result.PrimeiraDisputa.Perdedor);
            Assert.AreEqual(disputa1.Vencedor, result.PrimeiraDisputa.Vencedor);
            Assert.AreEqual(disputa2.Perdedor, result.SegundaDisputa.Perdedor);
            Assert.AreEqual(disputa2.Vencedor, result.SegundaDisputa.Vencedor);
            Assert.AreEqual(disputa3.Perdedor, result.TerceiraDisputa.Perdedor);
            Assert.AreEqual(disputa3.Vencedor, result.TerceiraDisputa.Vencedor);
            Assert.AreEqual(disputa4.Perdedor, result.QuartaDisputa.Perdedor);
            Assert.AreEqual(disputa4.Vencedor, result.QuartaDisputa.Vencedor);
        }

        private List<Filme> GerarGrupo()
        {
            var result = listaFilmes.PickRandom(4).ToList();
            listaFilmes.RemoveItens(result);
            result = result.OrdenarFormaGenerico(SortDirection.Ascending, ObjectUtilities.GetPropertyName(() => new Filme().PrimaryTitle));
            result = result.OrdenarFormaGenerico(SortDirection.Descending, ObjectUtilities.GetPropertyName(() => new Filme().SetAvageRatingDecimal));
            return result;
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A faseDeGrupo esta nula")]
        public void GerarFaseEliminatoriaTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var result = FaseEliminatoria.GerarFaseEliminatoria(null, null, null, null);
        }
    }
}
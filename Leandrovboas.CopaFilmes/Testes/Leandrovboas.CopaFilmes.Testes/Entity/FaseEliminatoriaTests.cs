using Leandrovboas.CopaFilmes.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class FaseEliminatoriaTests
    {
        private FaseDeGrupo FaseGrupo;

        [TestInitialize]
        public void Inicializar()
        {
            var listaFilmes = CriacaoListaFilmes.Criar();
            FaseGrupo = FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);
        }

        [TestMethod()]
        public void GerarFaseEliminatoriaTest()
        {
            var disputa1 = Disputa.GerarDisputa(FaseGrupo.GrupoA[0], FaseGrupo.GrupoB[1]);
            var disputa2 = Disputa.GerarDisputa(FaseGrupo.GrupoB[0], FaseGrupo.GrupoA[1]);
            var disputa3 = Disputa.GerarDisputa(FaseGrupo.GrupoC[0], FaseGrupo.GrupoD[1]);
            var disputa4 = Disputa.GerarDisputa(FaseGrupo.GrupoD[0], FaseGrupo.GrupoC[1]);

            var result = FaseEliminatoria.GerarFaseEliminatoria(FaseGrupo);

            Assert.AreEqual(disputa1.Perdedor, result.PrimeiraDisputa.Perdedor);
            Assert.AreEqual(disputa1.Vencedor, result.PrimeiraDisputa.Vencedor);
            Assert.AreEqual(disputa2.Perdedor, result.SegundaDisputa.Perdedor);
            Assert.AreEqual(disputa2.Vencedor, result.SegundaDisputa.Vencedor);
            Assert.AreEqual(disputa3.Perdedor, result.TerceiraDisputa.Perdedor);
            Assert.AreEqual(disputa3.Vencedor, result.TerceiraDisputa.Vencedor);
            Assert.AreEqual(disputa4.Perdedor, result.QuartaDisputa.Perdedor);
            Assert.AreEqual(disputa4.Vencedor, result.QuartaDisputa.Vencedor);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A faseDeGrupo esta nula")]
        public void GerarFaseEliminatoriaTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var result = FaseEliminatoria.GerarFaseEliminatoria(null);
        }
    }
}
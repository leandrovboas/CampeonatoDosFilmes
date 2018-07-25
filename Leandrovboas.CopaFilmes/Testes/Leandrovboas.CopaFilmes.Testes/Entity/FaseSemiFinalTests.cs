using Leandrovboas.CopaFilmes.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class FaseSemiFinalTests
    {

        private FaseDeGrupo faseGrupo;
        private FaseEliminatoria faseEliminatoria;

        [TestInitialize]
        public void Inicializar()
        {
            var listaFilmes = CriacaoListaFilmes.Criar();
            faseGrupo = FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);
            faseEliminatoria = FaseEliminatoria.GerarFaseEliminatoria(faseGrupo);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A faseEliminatoria esta nula")]
        public void GerarFaseSemiFinalTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var result = FaseEliminatoria.GerarFaseEliminatoria(null);
        }

        [TestMethod()]
        public void GerarFaseSemiFinalTest()
        {
            var disputa1 = Disputa.GerarDisputa(faseEliminatoria.PrimeiraDisputa.Vencedor, faseEliminatoria.SegundaDisputa.Vencedor);
            var disputa2 = Disputa.GerarDisputa(faseEliminatoria.TerceiraDisputa.Vencedor, faseEliminatoria.QuartaDisputa.Vencedor);

            var result = FaseSemiFinal.GerarFaseSemiFinal(faseEliminatoria);

            Assert.AreEqual(disputa1.Perdedor, result.PrimeiraDisputa.Perdedor);
            Assert.AreEqual(disputa1.Vencedor, result.PrimeiraDisputa.Vencedor);
            Assert.AreEqual(disputa2.Perdedor, result.SegundaDisputa.Perdedor);
            Assert.AreEqual(disputa2.Vencedor, result.SegundaDisputa.Vencedor);
        }
    }
}
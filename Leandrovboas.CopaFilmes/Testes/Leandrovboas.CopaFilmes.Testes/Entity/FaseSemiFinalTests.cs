using Leandrovboas.CopaFilmes.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class FaseSemiFinalTests
    {
        private Disputa PrimeiraDisputa;
        private Disputa SegundaDisputa;
        private Disputa TerceiraDisputa;
        private Disputa QuartaDisputa;

        [TestInitialize]
        public void Inicializar()
        {
            var listaFilmes = CriacaoListaFilmes.Criar();
            PrimeiraDisputa = Disputa.GerarDisputa(listaFilmes[0], listaFilmes[1]);
            SegundaDisputa = Disputa.GerarDisputa(listaFilmes[2], listaFilmes[3]);
            TerceiraDisputa = Disputa.GerarDisputa(listaFilmes[4], listaFilmes[4]);
            QuartaDisputa = Disputa.GerarDisputa(listaFilmes[5], listaFilmes[6]);
        }


        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A faseEliminatoria esta nula")]
        public void GerarFaseSemiFinalTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var result = FaseSemiFinal.GerarFaseSemiFinal(null, null, null, null);
        }

        [TestMethod()]
        public void GerarFaseSemiFinalTest()
        {
            var disputa1 = Disputa.GerarDisputa(PrimeiraDisputa.Vencedor, SegundaDisputa.Vencedor);
            var disputa2 = Disputa.GerarDisputa(TerceiraDisputa.Vencedor, QuartaDisputa.Vencedor);

            var result = FaseSemiFinal.GerarFaseSemiFinal(PrimeiraDisputa,SegundaDisputa, TerceiraDisputa, QuartaDisputa);

            Assert.AreEqual(disputa1.Perdedor, result.PrimeiraDisputa.Perdedor);
            Assert.AreEqual(disputa1.Vencedor, result.PrimeiraDisputa.Vencedor);
            Assert.AreEqual(disputa2.Perdedor, result.SegundaDisputa.Perdedor);
            Assert.AreEqual(disputa2.Vencedor, result.SegundaDisputa.Vencedor);
        }
    }
}
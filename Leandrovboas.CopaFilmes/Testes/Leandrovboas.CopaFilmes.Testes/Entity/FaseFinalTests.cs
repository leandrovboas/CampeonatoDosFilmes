using Leandrovboas.CopaFilmes.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class FaseFinalTests
    {
        private List<Filme> listaFilmes;
        private Disputa PrimeiraDisputa;
        private Disputa SegundaDisputa;

        [TestInitialize]
        public void Inicializar()
        {
            listaFilmes = CriacaoListaFilmes.Criar();
            PrimeiraDisputa = Disputa.GerarDisputa(listaFilmes[0], listaFilmes[1]);
            SegundaDisputa = Disputa.GerarDisputa(listaFilmes[2], listaFilmes[3]);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A FaseFinal esta nula")]
        public void GerarFaseFinalTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var result = FaseFinal.GerarFaseFinal(null, null);
        }

        [TestMethod()]
        public void GerarFaseFinalTest()
        {
            var disputa1 = Disputa.GerarDisputa(PrimeiraDisputa.Vencedor, SegundaDisputa.Vencedor);

            var result = FaseFinal.GerarFaseFinal(PrimeiraDisputa, SegundaDisputa);

            Assert.AreEqual(disputa1.Vencedor, result.PrimeiroLugar);
            Assert.AreEqual(disputa1.Perdedor, result.SeguntoLugar);
            Assert.AreEqual(SegundaDisputa.Perdedor, result.TerceiroLugar);
        }
    }
}
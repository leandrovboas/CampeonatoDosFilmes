using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class DisputaTests
    {
        private Filme filme1;
        private Filme filme2;

        [TestInitialize]
        public void Inicializar()
        {
            filme1 = new Filme
            {
                Id = "01",
                PrimaryTitle = "Filme001",
                AverageRating = "10.0",
                Year = 2018
            };

            filme2 = new Filme
            {
                Id = "02",
                PrimaryTitle = "Filme002",
                AverageRating = "08.0",
                Year = 2018
            };

        }

        [TestMethod()]
        public void GerarDisputaTest()
        {
            var result = Disputa.GerarDisputa(filme1, filme2);

            Assert.IsNotNull(result);
            Assert.AreEqual<Filme>(result.Vencedor, filme1);
            Assert.AreEqual<Filme>(result.Perdedor, filme2);
        }


        [TestMethod()]
        public void GerarDisputaMesmaNotaTest()
        {
            filme2.AverageRating = filme1.AverageRating;
            filme2.PrimaryTitle = $"A{filme2.PrimaryTitle}";
            var result = Disputa.GerarDisputa(filme1, filme2);

            Assert.IsNotNull(result);
            Assert.AreEqual<Filme>(result.Vencedor, filme2);
            Assert.AreEqual<Filme>(result.Perdedor, filme1);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "O filme1 esta nulo")]
        public void GerarDisputaTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var result = Disputa.GerarDisputa(null, filme2);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "O filme1 esta nulo")]
        public void GerarDisputaTest_DoisParametroNulo_ThrowsArgumentNullException()
        {
            var result = Disputa.GerarDisputa(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException), "O filme2 não possui nota")]
        public void GerarDisputaTest_ParametroSemNota_ThrowsArgumentNullException()
        {
            filme2.AverageRating = string.Empty;
            var result = Disputa.GerarDisputa(filme1, filme2);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException), "A cadeia de caracteres de entrada não estava em um formato correto.")]
        public void GerarDisputaTest_ParametroSemNotaDecimal_ThrowsArgumentNullException()
        {
            filme2.AverageRating = "Teste";
            var result = Disputa.GerarDisputa(filme1, filme2);
        }
    }
}
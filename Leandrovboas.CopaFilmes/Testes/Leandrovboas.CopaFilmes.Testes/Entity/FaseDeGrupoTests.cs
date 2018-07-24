using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{

    [TestClass()]
    public class FaseDeGrupoTests
    {
        private List<Filme> listaFilmes;

        [TestInitialize]
        public void Inicializar()
        {
            listaFilmes = new List<Filme>();
            for (int i = 0; i < 16; i++)
            {
                var teste = $"Teste - {i}";
                listaFilmes.Add(new Filme
                {
                    Id = teste,
                    PrimaryTitle = teste,
                    AverageRating = Convert.ToDecimal(i).ToString(),
                    Year = DateTime.Now.Year
                });
            }

        }

        [TestMethod()]
        public void GerarFaseDeGrupoTest()
        {
            var faseGrupo = FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);

            Assert.IsTrue(faseGrupo?.GrupoA?.Count == 4);
            var maiorValorGrupoA = faseGrupo.GrupoA.Max(elem => Math.Max(Convert.ToDecimal(elem.AverageRating), Convert.ToDecimal(elem.AverageRating)));
            Assert.AreEqual(maiorValorGrupoA.ToString(), faseGrupo.GrupoA[0].AverageRating);

            Assert.IsTrue(faseGrupo?.GrupoB?.Count == 4);
            var maiorValorGrupoB = faseGrupo.GrupoB.Max(elem => Math.Max(Convert.ToDecimal(elem.AverageRating), Convert.ToDecimal(elem.AverageRating)));
            Assert.AreEqual(maiorValorGrupoB.ToString(), faseGrupo.GrupoB[0].AverageRating);

            Assert.IsTrue(faseGrupo?.GrupoC?.Count == 4);
            var maiorValorGrupoC = faseGrupo.GrupoC.Max(elem => Math.Max(Convert.ToDecimal(elem.AverageRating), Convert.ToDecimal(elem.AverageRating)));
            Assert.AreEqual(maiorValorGrupoC.ToString(), faseGrupo.GrupoC[0].AverageRating);

            Assert.IsTrue(faseGrupo?.GrupoD?.Count == 4);
            var maiorValorGrupoD = faseGrupo.GrupoD.Max(elem => Math.Max(Convert.ToDecimal(elem.AverageRating), Convert.ToDecimal(elem.AverageRating)));
            Assert.AreEqual(maiorValorGrupoD.ToString(), faseGrupo.GrupoD[0].AverageRating);
        }
    }
}
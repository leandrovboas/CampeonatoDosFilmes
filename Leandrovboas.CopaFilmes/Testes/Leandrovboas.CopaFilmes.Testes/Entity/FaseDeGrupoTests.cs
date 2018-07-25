using Leandrovboas.CopaFilmes.Testes;
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
        public void Inicializar() => 
            listaFilmes = CriacaoListaFilmes.Criar();

        [TestMethod()]
        public void GerarFaseDeGrupoTest()
        {
            var faseGrupo = FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);

            Assert.IsTrue(faseGrupo?.GrupoA?.Count == 4);
            var maiorValorGrupoA = faseGrupo.GrupoA.Max(elem => Math.Max(elem.SetAvageRatingDecimal, elem.SetAvageRatingDecimal));
            Assert.AreEqual(maiorValorGrupoA, faseGrupo.GrupoA.FirstOrDefault().SetAvageRatingDecimal);

            Assert.IsTrue(faseGrupo?.GrupoB?.Count == 4);
            var maiorValorGrupoB = faseGrupo.GrupoB.Max(elem => Math.Max(elem.SetAvageRatingDecimal, elem.SetAvageRatingDecimal));
            Assert.AreEqual(maiorValorGrupoB, faseGrupo.GrupoB.FirstOrDefault().SetAvageRatingDecimal);

            Assert.IsTrue(faseGrupo?.GrupoC?.Count == 4);
            var maiorValorGrupoC = faseGrupo.GrupoC.Max(elem => Math.Max(elem.SetAvageRatingDecimal, elem.SetAvageRatingDecimal));
            Assert.AreEqual(maiorValorGrupoC, faseGrupo.GrupoC.FirstOrDefault().SetAvageRatingDecimal);

            Assert.IsTrue(faseGrupo?.GrupoD?.Count == 4);
            var maiorValorGrupoD = faseGrupo.GrupoD.Max(elem => Math.Max(elem.SetAvageRatingDecimal, elem.SetAvageRatingDecimal));
            Assert.AreEqual(maiorValorGrupoD, faseGrupo.GrupoD.FirstOrDefault().SetAvageRatingDecimal);
        }
    }
}
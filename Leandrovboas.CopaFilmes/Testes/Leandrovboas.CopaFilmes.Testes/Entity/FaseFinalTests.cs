using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Leandrovboas.CopaFilmes.Testes;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class FaseFinalTests
    {
        private FaseDeGrupo faseGrupo;
        private FaseEliminatoria faseEliminatoria;
        private FaseSemiFinal faseSemiFinal;

        [TestInitialize]
        public void Inicializar()
        {
            var listaFilmes = CriacaoListaFilmes.Criar();
            faseGrupo = FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);
            faseEliminatoria = FaseEliminatoria.GerarFaseEliminatoria(faseGrupo);
            faseSemiFinal = FaseSemiFinal.GerarFaseSemiFinal(faseEliminatoria);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A FaseFinal esta nula")]
        public void GerarFaseFinalTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var result = FaseFinal.GerarFaseFinal(null);
        }

        [TestMethod()]
        public void GerarFaseFinalTest()
        {
            var disputa1 = Disputa.GerarDisputa(faseSemiFinal.PrimeiraDisputa.Vencedor, faseSemiFinal.SegundaDisputa.Vencedor);

            var result = FaseFinal.GerarFaseFinal(faseSemiFinal);

            Assert.AreEqual(disputa1.Vencedor, result.PrimeiroLugar);
            Assert.AreEqual(disputa1.Perdedor, result.SeguntoLugar);
            Assert.AreEqual(faseSemiFinal.PrimeiraDisputa.Perdedor, result.TerceiroLugar);
        }
    }
}
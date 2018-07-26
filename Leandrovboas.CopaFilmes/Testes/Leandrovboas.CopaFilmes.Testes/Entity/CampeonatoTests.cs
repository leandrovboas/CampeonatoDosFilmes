using Leandrovboas.CopaFilmes.Testes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Entity.Tests
{
    [TestClass()]
    public class CampeonatoTests
    {
        private List<Filme> listaFilmes;

        [TestInitialize]
        public void Inicializar() =>
            listaFilmes = CriacaoListaFilmes.Criar();

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "O filme1 esta nulo")]
        public void GerarCampeonatoTest_ParametroNulo_ThrowsArgumentNullException()
        {
            var campeonato = Campeonato.GerarCampeonato(null);
        }

        [TestMethod()]
        public void GerarCampeonatoTest()
        {
            var campeonato = Campeonato.GerarCampeonato(listaFilmes);
        }
    }
}
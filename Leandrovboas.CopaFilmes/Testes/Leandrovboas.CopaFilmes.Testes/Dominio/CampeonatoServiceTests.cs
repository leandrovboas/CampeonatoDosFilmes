using Leandrovboas.CopaFilmes.Dominio.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio.Servicos.Tests
{
    [TestClass()]
    public class CampeonatoServiceTests
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
        public void RealizarCampeonatoAsyncTest()
        {
            var campeonatoServico = new CampeonatoServico();
            var campeonato = campeonatoServico.RealizarCampeonato(listaFilmes);

            Assert.IsNotNull(campeonato);
            Assert.IsNotNull(campeonato.FaseDeGrupo);
            Assert.IsNotNull(campeonato.FaseDeGrupo.GrupoA);
            Assert.IsNotNull(campeonato.FaseDeGrupo.GrupoB);
            Assert.IsNotNull(campeonato.FaseDeGrupo.GrupoC);
            Assert.IsNotNull(campeonato.FaseDeGrupo.GrupoD);
            Assert.IsNotNull(campeonato.FaseEliminatoria);
            Assert.IsNotNull(campeonato.FaseEliminatoria.PrimeiraDisputa);
            Assert.IsNotNull(campeonato.FaseEliminatoria.SegundaDisputa);
            Assert.IsNotNull(campeonato.FaseSemiFinal);
            Assert.IsNotNull(campeonato.FaseFinal);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "O Parametro listaFilmes encontra-se null")]
        public void RealizarCampeonatoAsync_ParametroNulo_ThrowsArgumentNullException()
        {
            var campeonatoServico = new CampeonatoServico();
            var campeonato = campeonatoServico.RealizarCampeonato(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), noExceptionMessage: "Deve conter 16 filmes para iniciar o Campeonato")]
        public void RealizarCampeonatoAsync_ParametroVazio_ThrowsArgumentOutOfRangeException()
        {
            var campeonatoServico = new CampeonatoServico();
            var campeonato = campeonatoServico.RealizarCampeonato(new List<Filme>());
        }

    }
}
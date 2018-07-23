using Leandrovboas.CopaFilmes.Infra.Repositorio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio.Servicos.Tests
{
    [TestClass()]
    public class FilmeServicoTests
    {
        private const int TOTAL_FILMES = 64;

        [TestMethod]
        public void GetAllAsyncTest()
        {
            var filmesServico = new FilmeServico(new FilmesRepositorio());
            var filmes = filmesServico.GetAllAsync().Result;

            Assert.IsNotNull(filmes);
            Assert.IsTrue(filmes.ToList().Count == TOTAL_FILMES);
        }
    }
}
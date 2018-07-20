using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Infra.Repositorio.Tests
{
    [TestClass()]
    public class FilmesRepositorioTests
    {
        private const int TOTAL_FILMES = 64;

        [TestMethod]
        public void GetAllAsyncTest()
        {
            var filmesRepositorio = new FilmesRepositorio();
            var filmes = filmesRepositorio.GetAllAsync().Result;

            Assert.IsNotNull(filmes);
            Assert.IsTrue(filmes.ToList().Count == TOTAL_FILMES);
        }
    }
}
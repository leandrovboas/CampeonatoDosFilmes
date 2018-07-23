using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

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
            FaseDeGrupo.GerarFaseDeGrupo(listaFilmes);
        }
    }
}
using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Testes
{
    public static class CriacaoListaFilmes
    {
        public static List<Filme> Criar()
        {
            var listaFilmes = new List<Filme>();
            for (int i = 0; i < 16; i++)
            {
                var teste = $"Teste - {i}";
                listaFilmes.Add(new Filme
                {
                    Id = teste,
                    PrimaryTitle = teste,
                    AverageRating = $"{i}.0",
                    Year = DateTime.Now.Year
                });
            }

            return listaFilmes;
        }
    }
}

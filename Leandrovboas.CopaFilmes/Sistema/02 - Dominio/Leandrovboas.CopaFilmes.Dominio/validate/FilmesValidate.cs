using Leandrovboas.CopaFilmes.Dominio.Entity;
using System;
using System.Collections.Generic;

namespace Leandrovboas.CopaFilmes.Dominio
{
    public static class FilmesValidate
    {
        private const int QUANTIDADE_FILMES_CAMPEOATO = 16;

        public static void Validar(List<Filme> listaFilmes)
        {
            if (listaFilmes == null) throw new ArgumentNullException(nameof(listaFilmes), $"O Parametro {nameof(listaFilmes)} encontra-se null");
            if (listaFilmes.Count != QUANTIDADE_FILMES_CAMPEOATO) throw new ArgumentOutOfRangeException(nameof(listaFilmes), $"Deve conter {QUANTIDADE_FILMES_CAMPEOATO} filmes para iniciar o Campeonato");
        }
    }
}

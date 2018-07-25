﻿using Leandrovboas.CopaFilmes.Dominio.validate;
using System.Collections.Generic;
using System.Linq;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Disputa
    {
        #region Construtor
        protected Disputa(Filme filme1, Filme filme2)
        {
            FilmesValidate.ValidarDisputa(filme1, filme2);

            if (filme1.SetAvageRatingDecimal == filme2.SetAvageRatingDecimal)
            {
                var disputaEmpate = new DisputaEmpate(filme1, filme2);
                Vencedor = disputaEmpate.EmpateVencedor;
                Perdedor = disputaEmpate.EmpatePerdedor;
                return;
            }

            Vencedor = GerarVencedor(filme1, filme2);
            Perdedor = GerarPerdedor(filme1, filme2);
        }
        #endregion

        #region Propriedades
        public Filme Vencedor { get; }
        public Filme Perdedor { get; } 
        #endregion

        #region MetodosPublicos
        public static Disputa GerarDisputa(Filme filme1, Filme filme2) =>
           new Disputa(filme1, filme2);
        #endregion

        #region MetodosPrivados
        private static Filme GerarVencedor(Filme filme1, Filme filme2) =>
            filme1.SetAvageRatingDecimal > filme2.SetAvageRatingDecimal ? filme1 : filme2;

        private static Filme GerarPerdedor(Filme filme1, Filme filme2) =>
            filme1.SetAvageRatingDecimal < filme2.SetAvageRatingDecimal ? filme1 : filme2;  
        #endregion
    }
}
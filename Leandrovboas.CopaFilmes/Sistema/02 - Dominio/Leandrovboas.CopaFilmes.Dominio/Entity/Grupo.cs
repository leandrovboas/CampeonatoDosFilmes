using Leandrovboas.CopaFilmes.Dominio.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leandrovboas.CopaFilmes.Dominio.Entity
{
    public class Grupo
    {
        public static List<Filme> GerarGrupos(List<Filme> listaFilmes)
        {
            var result = listaFilmes.PickRandom(4).ToList();
            return OrdenarFaseDeGrupo.Ordenar(result);
        }
    }
}

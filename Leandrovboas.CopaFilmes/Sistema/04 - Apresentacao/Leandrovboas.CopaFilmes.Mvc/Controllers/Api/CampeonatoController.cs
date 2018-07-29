using AutoMapper;
using Leandrovboas.CopaFilmes.Aplicacao.Interfaces;
using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Mvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Leandrovboas.CopaFilmes.Mvc.Controllers.Api
{
    [RoutePrefix("Campeonato/api")]
    public class CampeonatoController : ApiController
    {
        private readonly ICampeonatoServicoApp _servicoApp;

        public CampeonatoController(ICampeonatoServicoApp servicoApp)
        {
            _servicoApp = servicoApp;
        }


        [HttpPost]
        [Route("IniciarCampeonato")]
        /// <summary>
        /// Realiza um campeonato entre os filmes para definir um vencedo
        /// </summary>
        /// <param name="listaFilmes">Lista contendo 16 filmes para realizar o campeonato</param>
        /// <returns>Um historico do campeonato e os tres promeiros colocados</returns>
        public async Task<IHttpActionResult> IniciarCampeonatoAsync(List<FilmeViewModel> listaFilmes)
        {
            if (listaFilmes == null || listaFilmes.Count != 16) return BadRequest("Lista de Filmes invalida para realizar essa operação, verifique a quantirade de filmes obrigatórios");


            var resultado = _servicoApp.RealizarCampeonato(Mapper.Map<List<Filme>>(listaFilmes));
            if (resultado != null)
            {
                var model = Mapper.Map<CampeonatoViewModel>(resultado);
                return Ok(model);
            }
            else
            {
                return NotFound();
            }
        }
    }
}

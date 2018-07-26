using AutoMapper;
using Leandrovboas.CopaFilmes.Aplicacao.Interfaces;
using Leandrovboas.CopaFilmes.Dominio.Entity;
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
        [Route("IniciarCampeonato/{listaFilmes}")]
        public async Task<IHttpActionResult> IniciarCampeonatoAsync(List<Filme> listaFilmes)
        {
            if (listaFilmes == null || listaFilmes.Count != 16) return BadRequest("Lista de Filmes invalida para realizar essa operação, verifique a quantirade de filmes obrigatórios");

            var resultado = _servicoApp.RealizarCampeonato(listaFilmes);
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

using AutoMapper;
using Leandrovboas.CopaFilmes.Aplicacao.Interfaces;
using Leandrovboas.CopaFilmes.Mvc.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Leandrovboas.CopaFilmes.Mvc.Controllers.Api
{
    [RoutePrefix("Filmes/api/filmes")]
    public class FilmeApiController : ApiController
    {
        private readonly IFilmeServicoApp ServicoApp;
        public FilmeApiController(IFilmeServicoApp servicoApp)
        {
            ServicoApp = servicoApp;
        }

        [HttpGet]
        [Route("listar")]
        public async Task<IHttpActionResult> ListarTodasAsync()
        {

            var filmes = await ServicoApp.GetAllAsync();
            if (filmes != null)
            {
                var model = Mapper.Map<IEnumerable<FilmeViewModel>>(filmes);
                return Ok(model);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
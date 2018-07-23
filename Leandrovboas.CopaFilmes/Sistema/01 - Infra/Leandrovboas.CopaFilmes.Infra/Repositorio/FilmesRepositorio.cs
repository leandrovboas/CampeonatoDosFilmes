using Leandrovboas.CopaFilmes.Dominio.Entity;
using Leandrovboas.CopaFilmes.Dominio.Interfaces.Repositorio;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Leandrovboas.CopaFilmes.Infra.Repositorio
{
    public class FilmesRepositorio: IFilmesRepositorio
    {
        private readonly HttpClient Client;
        private readonly string UrlApiFilmes = ConfigurationManager.AppSettings["URL_WEBAPI_COPA"];

        #region Contructor
        public FilmesRepositorio()
        {
            if (string.IsNullOrWhiteSpace(UrlApiFilmes)) throw new ConfigurationErrorsException("AppSettings URL_WEBAPI_COPA não configurada no arquivo de configuração");

            if (Client == null)
            {
                Client = new HttpClient
                {
                    BaseAddress = new Uri(UrlApiFilmes)
                };
                Client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            }
        }
        #endregion

        #region PublicMethod
        public async Task<IEnumerable<Filme>> GetAllAsync()
        {
            var response = await Client.GetAsync("api/filmes");

            if (response.IsSuccessStatusCode)
            {
                var filmes = response?.Content?.ReadAsAsync<IEnumerable<Filme>>().Result;
                return filmes.OrderBy(o => o.PrimaryTitle).ToList();
            }
            else throw new HttpRequestException($"StatusCodeError: {response.StatusCode} ErrorMessage: Problema ao conectar com a WebApi externa");
        }
        #endregion
    }
}

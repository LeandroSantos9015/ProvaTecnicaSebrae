using Newtonsoft.Json;
using ProvaTecnicaSebrae.Interfaces;
using ProvaTecnicaSebrae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Services
{
    public class EnderecoService : IEnderecoService
    {
        public async Task<string> RetornaEndereco(string cep)
        {
            string urlConsulta = $"http://viacep.com.br/ws/{cep}/json/";

            //string url = "https://localhost:44386/weatherforecast";

            JsonSerializerSettings settings = new JsonSerializerSettings
            {
                Formatting = Formatting.Indented,
                NullValueHandling = NullValueHandling.Ignore
            };

            using (var client = new HttpClient())
            {
                try
                {
                    using (var response = await client.GetAsync(urlConsulta))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            var consulta = await response.Content.ReadAsStringAsync();
                            // var objeto = JsonConvert.DeserializeObject<EnderecoDTO>(consulta);

                            return consulta;

                        }
                        else
                        {
                            return null;
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
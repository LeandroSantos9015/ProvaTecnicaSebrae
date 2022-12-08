using Microsoft.AspNetCore.Mvc;
using ProvaTecnicaSebrae.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class EnderecoController : ControllerBase
    {
        private readonly IEnderecoService _enderecoService;

        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet]
        [Route("consulta")]
        public async Task<IActionResult> Consulta(string cep)
        {
            var retorno = await _enderecoService.RetornaEndereco(cep);

            return Ok(retorno);
        }

    }
}

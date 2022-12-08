using Microsoft.AspNetCore.Mvc;
using ProvaTecnicaSebrae.Interfaces;
using ProvaTecnicaSebrae.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProvaTecnicaSebrae.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaController : ControllerBase
    {

        private readonly IContaService _contaService;

        public ContaController(IContaService contaService)
        {
            _contaService = contaService;
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(ContaDTO conta)
        {
            var retorno = _contaService.Create(conta);

            return Ok(retorno);
        }

        [HttpGet]
        [Route("read")]
        public IActionResult Read()
        {

            var retorno = _contaService.Read();

            return Ok(retorno);

        }

        [HttpPost]
        [Route("update")]
        public IActionResult Update(ContaDTO conta)
        {
            var retorno = _contaService.Update(conta);

            return Ok(retorno);

        }

        [HttpPost]
        [Route("delete")]

        public IActionResult Delete(Int64 id)
        {
            var retorno = _contaService.Delete(id);

            return Ok(retorno);
        }
    }
}
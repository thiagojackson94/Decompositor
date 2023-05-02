using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Decompositor.Interface;

namespace Decompositor.API.Controllers
{
    [ApiController]
    public class DecompositorController : ControllerBase
    {
        private readonly IDecompositor _decompositor;
        public DecompositorController(IDecompositor decompositor)
        {
            _decompositor = decompositor;
        }

        [HttpGet]
        [Route("decompor")]
        public IActionResult Obter(string numEntrada)
        {
            try
            {
                var resultado = _decompositor.DecomporNumero(numEntrada);
                return Ok(resultado);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, e.Message);
            }
        }
    }
}

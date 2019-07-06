using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Rest.Domain.Ententies;
using Rest.Domain.Interfaces.Services;

namespace Rest.Servico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        private readonly IPratoService _service; 

        public PratoController(IPratoService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetOne(int id)
        {
            try
            {
                return Ok(_service.GetOne(id));
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // POST: api/Prato
        [HttpPost("")]
        public IActionResult create([FromBody] Prato prato)
        {
            try
            {
                if (prato == null)
                {
                    return BadRequest("Objeto inválido");
                }
                _service.Insert(prato);

                return Created("getone", new { id = prato.IdPrato });

            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        // PUT: api/Prato/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Prato prato)
        {
            try
            {
                if (prato == null)
                {
                    return BadRequest("Objeto inválido");
                }
                _service.Update(id, prato);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                _service.Delete(id);

                return NoContent();
            }
            catch (Exception e)
            {
                return BadRequest(e.Message);
            }
        }
    }
}

using System;
using Microsoft.AspNetCore.Mvc;
using Rest.Domain.Ententies;
using Rest.Domain.Interfaces.Services;

namespace Rest.Servico.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RestauranteController : ControllerBase
    {
        private IRestauranteService _service;
        

        public RestauranteController(IRestauranteService service)
        {
            _service = service;
        }

        [HttpGet("")]
        public IActionResult GetAll()
        {
            return Ok(_service.GetAll());
        }

        // GET: api/Restaurante/5
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

        // POST: api/Restaurante
        [HttpPost("")]
        public IActionResult Post([FromBody] Restaurante restaurante)
        {
            try
            {
                if (restaurante == null)
                {
                    return BadRequest("Objeto inválido");
                }
                _service.Insert(restaurante);

                return Created("getone", new { id = restaurante.IdRestaurante });
            }
            catch (Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }

        //PUT: api/Restaurante/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Restaurante restaurante)
        {
            try
            {
                if (restaurante == null)
                {
                    return BadRequest("Objeto inválido");
                }
                _service.Update(id, restaurante);

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

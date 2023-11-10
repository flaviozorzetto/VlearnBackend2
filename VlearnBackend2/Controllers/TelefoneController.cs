using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Controllers
{
    public class TelefoneController : Controller, IController<TelefoneRequestDto>
    {
        private readonly ITelefoneService _service;
        public TelefoneController(ITelefoneService service)
        {
            _service = service;
        }

        [HttpGet("/telefone")]
        public IActionResult Index()
        {
            return Ok(_service.GetAllTelefone());
        }

        [ProducesResponseType(typeof(Telefone), 200)]
        [HttpGet("/telefone/{id}")]
        public IActionResult FindById(int id)
        {
            var telefone = _service.GetTelefoneById(id);

            if (telefone == null)
            {
                return NotFound("Telefone não encontrado");
            }

            return Ok(telefone);
        }

        [HttpPost("/telefone")]
        public IActionResult Add([FromBody] TelefoneRequestDto telefoneRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var telefone = _service.CreateTelefone(telefoneRequestDto);

            return Ok(telefone);
        }

        [HttpDelete("/telefone/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool deleted = _service.DeleteTelefoneById(id);

                if (!deleted)
                {
                    return NotFound("Telefone não encontrado");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, InnerMessage = ex.InnerException?.Message });
            }

            return NoContent();
        }

        [HttpPut("/telefone/{id}")]
        public IActionResult Update(int id, [FromBody] TelefoneRequestDto telefoneRequestDto)
        {
            var telefone = _service.UpdateTelefoneById(id, telefoneRequestDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (telefone == null)
            {
                return NotFound("Telefone não encontrado");
            }

            return Ok(telefone);
        }
    }
}

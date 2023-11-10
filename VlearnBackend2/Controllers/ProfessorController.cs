using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Controllers
{
    public class ProfessorController : Controller, IController<ProfessorRequestDto>
    {
        private readonly IProfessorService _service;
        public ProfessorController(IProfessorService service)
        {
            _service = service;
        }

        [HttpGet("/professor")]
        public IActionResult Index()
        {
            return Ok(_service.GetAllProfessor());
        }

        [ProducesResponseType(typeof(Professor), 200)]
        [HttpGet("/professor/{id}")]
        public IActionResult FindById(int id)
        {
            var professor = _service.GetProfessorById(id);

            if (professor == null)
            {
                return NotFound("Professor não encontrado");
            }

            return Ok(professor);
        }

        [HttpPost("/professor")]
        public IActionResult Add([FromBody] ProfessorRequestDto professorRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var professor = _service.CreateProfessor(professorRequestDto);

            return Ok(professor);
        }

        [HttpDelete("/professor/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool deleted = _service.DeleteProfessorById(id);

                if (!deleted)
                {
                    return NotFound("Professor não encontrado");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, InnerMessage = ex.InnerException?.Message });
            }

            return NoContent();
        }

        [HttpPut("/professor/{id}")]
        public IActionResult Update(int id, [FromBody] ProfessorRequestDto professorRequestDto)
        {
            var professor = _service.UpdateProfessorById(id, professorRequestDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (professor == null)
            {
                return NotFound("Professor não encontrado");
            }

            return Ok(professor);
        }
    }
}

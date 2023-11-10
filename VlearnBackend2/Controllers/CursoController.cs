using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Controllers
{
    public class CursoController : Controller, IController<CursoRequestDto>
    {
        private readonly ICursoService _service;
        public CursoController(ICursoService service)
        {
            _service = service;
        }

        [HttpGet("/curso")]
        public IActionResult Index()
        {
            return Ok(_service.GetAllCurso());
        }

        [ProducesResponseType(typeof(Curso), 200)]
        [HttpGet("/curso/{id}")]
        public IActionResult FindById(int id)
        {
            var curso = _service.GetCursoById(id);

            if (curso == null)
            {
                return NotFound("Curso não encontrado");
            }

            return Ok(curso);
        }

        [HttpPost("/curso")]
        public IActionResult Add([FromBody] CursoRequestDto cursoRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var curso = _service.CreateCurso(cursoRequestDto);

            return Ok(curso);
        }

        [HttpDelete("/curso/{id}")]
        public IActionResult Delete(int id)
        {
            try
            {
                bool deleted = _service.DeleteCursoById(id);

                if (!deleted)
                {
                    return NotFound("Curso não encontrado");
                }
            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, InnerMessage = ex.InnerException?.Message });
            }

            return NoContent();
        }

        [HttpPut("/curso/{id}")]
        public IActionResult Update(int id, [FromBody] CursoRequestDto cursoRequestDto)
        {
            var curso = _service.UpdateCursoById(id, cursoRequestDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (curso == null)
            {
                return NotFound("Curso não encontrado");
            }

            return Ok(curso);
        }
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Controllers
{
    public class AlunoController : Controller, IController<AlunoRequestDto>
    {
        private readonly IAlunoService _service;
        public AlunoController(IAlunoService service) {
            _service = service;
        }

        [HttpGet("/aluno")]
        public IActionResult Index()
        {
            return Ok(_service.GetAllAluno());
        }

        [HttpGet("/aluno/{id}")]
        public IActionResult FindById(int id)
        {
            var aluno = _service.GetAlunoById(id);

            if (aluno == null)
            {
                return NotFound("Aluno não encontrado");
            }

            return Ok(aluno);
        }

        [HttpPost("/aluno")]
        public IActionResult Add([FromBody] AlunoRequestDto alunoRequestDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var aluno = _service.CreateAluno(alunoRequestDto);

            return Ok(aluno);
        }

        [HttpDelete("/aluno/{id}")]
        public IActionResult Delete(int id)
        {
            bool deleted = _service.DeleteAlunoById(id);

            if (!deleted)
            {
                return NotFound("Aluno não encontrado");
            }

            return NoContent();
        }

        [HttpPut("/aluno/{id}")]
        public IActionResult Update(int id, [FromBody] AlunoRequestDto alunoRequestDto)
        {
            var aluno = _service.UpdateAlunoById(id, alunoRequestDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (aluno == null)
            {
                return NotFound("Aluno não encontrado");
            }

            return Ok(aluno);
        }
    }
}

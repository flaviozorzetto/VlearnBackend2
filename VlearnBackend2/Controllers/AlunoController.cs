using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Controllers
{
    public class AlunoController : Controller, IController<AlunoRequestDto>
    {
        private readonly IAlunoService _service;
        private readonly ILogger<AlunoController> _logger;
        public AlunoController(IAlunoService service, ILogger<AlunoController> logger)
        {
            _service = service;
            _logger = logger;
        }

        [HttpGet("/aluno")]
        public IActionResult Index()
        {
            _logger.LogInformation("Getting all alunos");
            return Ok(_service.GetAllAluno());
        }

        [ProducesResponseType(typeof(Aluno), 200)]
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
            try
            {
                bool deleted = _service.DeleteAlunoById(id);

                if (!deleted)
                {
                    return NotFound("Aluno não encontrado");
                }

            }
            catch (Exception ex)
            {
                return BadRequest(new { Message = ex.Message, InnerMessage = ex.InnerException?.Message });
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

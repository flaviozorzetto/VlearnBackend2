using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;

namespace VlearnBackend2.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoService _service;
        public AlunoController(IAlunoService service) {
            _service = service;
        }

        [HttpGet("/alunos")]
        public IActionResult Index()
        {
            return Ok("Teste");
        }
    }
}

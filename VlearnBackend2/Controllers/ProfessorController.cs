using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;

namespace VlearnBackend2.Controllers
{
    public class ProfessorController : Controller
    {
        private readonly IProfessorService _service;
        public ProfessorController(IProfessorService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

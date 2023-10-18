using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;

namespace VlearnBackend2.Controllers
{
    public class CursoController : Controller
    {
        private readonly ICursoService _service;
        public CursoController(ICursoService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

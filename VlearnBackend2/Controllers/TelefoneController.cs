using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;

namespace VlearnBackend2.Controllers
{
    public class TelefoneController : Controller
    {
        private readonly ITelefoneService _service;
        public TelefoneController(ITelefoneService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}

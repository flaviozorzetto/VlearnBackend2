using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;

namespace VlearnBackend2.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return Ok("Teste");
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService _service;
        public LoginController(ILoginService service)
        {
            _service = service;
        }

        [HttpGet("/login")]
        public IActionResult Index()
        {
            return Ok(_service.GetAllLogin());
        }

        [HttpPost("/login")]
        public IActionResult Add(LoginRequestDto loginRequestDto)
        {
            var login = _service.CreateLogin(loginRequestDto);
            return Ok();
        }
    }
}

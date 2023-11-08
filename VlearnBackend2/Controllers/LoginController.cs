using Microsoft.AspNetCore.Mvc;
using VlearnBackend2.Interfaces;
using VlearnBackend2.Models;
using VlearnBackend2.Models.Dto;

namespace VlearnBackend2.Controllers
{
    public class LoginController : Controller, IController<LoginRequestDto>
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

        [ProducesResponseType(typeof(Login), 200)]
        [HttpGet("/login/{id}")]
        public IActionResult FindById(int id)
        {
            var login = _service.GetLoginById(id);

            if(login == null)
            {
                return NotFound("Login não encontrado");
            }

            return Ok(login);
        }

        [HttpPost("/login")]
        public IActionResult Add([FromBody] LoginRequestDto loginRequestDto)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var login = _service.CreateLogin(loginRequestDto);

            return Ok(login);
        }

        [HttpDelete("/login/{id}")]
        public IActionResult Delete(int id)
        {
            bool deleted = _service.DeleteLoginById(id);

            if(!deleted)
            {
                return NotFound("Login não encontrado");
            }

            return NoContent();
        }

        [HttpPut("/login/{id}")]
        public IActionResult Update(int id, [FromBody] LoginRequestDto loginRequestDto)
        {
            var login = _service.UpdateLoginById(id, loginRequestDto);

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (login == null)
            {
                return NotFound("Login não encontrado");
            }

            return Ok(login);
        }
    }
}

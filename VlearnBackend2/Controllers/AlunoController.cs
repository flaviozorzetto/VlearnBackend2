using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace VlearnBackend2.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            return Ok("Teste");
        }
    }
}

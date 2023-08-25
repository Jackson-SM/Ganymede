using Microsoft.AspNetCore.Mvc;

namespace Ganymede.Controllers
{
    [ApiController]
    [Route("users")]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

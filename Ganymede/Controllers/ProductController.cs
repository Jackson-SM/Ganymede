using Microsoft.AspNetCore.Mvc;

namespace Ganymede.Controllers
{
    [ApiController]
    [Route("products")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

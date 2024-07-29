using Microsoft.AspNetCore.Mvc;

namespace PrimeiroAspNet.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace PrimeiroASPNet.Controllers
{
    public class MASAController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

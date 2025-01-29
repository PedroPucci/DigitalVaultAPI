using Microsoft.AspNetCore.Mvc;

namespace DigitalVaultAPI.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

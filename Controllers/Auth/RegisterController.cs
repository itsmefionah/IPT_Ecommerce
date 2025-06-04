using Microsoft.AspNetCore.Mvc;

namespace VYBR_IPT_ETR.Controllers.Auth
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}

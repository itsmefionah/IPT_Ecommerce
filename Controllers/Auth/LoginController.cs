using Microsoft.AspNetCore.Mvc;

namespace VYBR_IPT_ETR.Controllers.Auth
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }
    }
}

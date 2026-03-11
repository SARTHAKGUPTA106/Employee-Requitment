using Microsoft.AspNetCore.Mvc;

namespace Employee_Requitment.Controllers
{
    public class LoginPageController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/LoginPage/Index.cshtml");
        }
    }
}

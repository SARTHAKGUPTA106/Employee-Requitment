using Microsoft.AspNetCore.Mvc;

namespace Employee_Requitment.Controllers
{
    public class LoginPageController : Controller
    {

        private readonly IHelloService _helloService;

        public LoginPageController(IHelloService helloService)
        {
            _helloService = helloService;
        }


        public IActionResult Index()
        {
            string message = _helloService.SayHello("World");

            return View("~/Views/LoginPage/Index.cshtml");
        }
    }
}

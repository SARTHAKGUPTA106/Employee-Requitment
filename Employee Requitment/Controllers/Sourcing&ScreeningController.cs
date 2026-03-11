using Microsoft.AspNetCore.Mvc;

namespace EmployeeRcruitmentProject.Controllers
{
    public class Sourcing_ScreeningController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/Sourcing_Screening/Index.cshtml");
        }
    }
}

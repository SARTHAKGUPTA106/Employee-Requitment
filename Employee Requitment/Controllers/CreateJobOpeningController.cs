using Microsoft.AspNetCore.Mvc;

namespace EmployeeRcruitmentProject.Controllers
{
    public class CreateJobOpeningController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/CreateJobOpening/Index.cshtml");
        }
    }
}

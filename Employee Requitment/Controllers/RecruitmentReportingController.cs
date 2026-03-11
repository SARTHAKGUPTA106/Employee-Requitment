using Microsoft.AspNetCore.Mvc;

namespace EmployeeRcruitmentProject.Controllers
{
    public class RecruitmentReportingController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/RecruitmentReporting/Index.cshtml");
        }
    }
}

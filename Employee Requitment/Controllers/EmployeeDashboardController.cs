using Microsoft.AspNetCore.Mvc;

namespace EmployeeRcruitmentProject.Controllers
{
    public class EmployeeDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/EmployeeDashboard/Index.cshtml");
        }
    }
}

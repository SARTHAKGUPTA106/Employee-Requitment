using Microsoft.AspNetCore.Mvc;

namespace EmployeeRcruitmentProject.Controllers
{
    public class CandidateShortlisting_InterviewProcessController : Controller
    {
        public IActionResult Index()
        {
            return View("~/Views/CandidateShortlisting_InterviewProcess/Index.cshtml");
        }
    }
}

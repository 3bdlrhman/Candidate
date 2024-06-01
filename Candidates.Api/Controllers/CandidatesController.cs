using Microsoft.AspNetCore.Mvc;

namespace Candidates.Api.Controllers
{
    public class CandidatesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

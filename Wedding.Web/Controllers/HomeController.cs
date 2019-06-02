using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Abstractions.Services;
using Wedding.Web.Models;
using System.Threading.Tasks;

namespace Wedding.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWeddingStudioGroupService _studioGroupService;

        public HomeController(IWeddingStudioGroupService studioGroupService)
        {
            _studioGroupService = studioGroupService;
        }
        public async Task<IActionResult> Index()
        {

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Header()
        {
            return PartialView("_Header");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abstractions.Services;
using Microsoft.AspNetCore.Mvc;

namespace Wedding.Web.Controllers
{
    public class StudioController : Controller
    {
        private readonly IWeddingStudioService _weddingStudioService;

        public StudioController(IWeddingStudioService weddingStudioService)
        {
            _weddingStudioService = weddingStudioService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public ActionResult ProductsList(int studioId)
        {
            var listProducts = _weddingStudioService.GetWeddingStudioAsync(studioId);
            return View(listProducts);
        }
    }
}
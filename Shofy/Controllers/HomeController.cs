using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Shofy.Controllers
{
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return View(); 
        }
    }
}

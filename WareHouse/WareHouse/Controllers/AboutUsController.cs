using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WareHouse.Models;

namespace WareHouse.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutUs()
        {
            return View();
        }

      

    }
}

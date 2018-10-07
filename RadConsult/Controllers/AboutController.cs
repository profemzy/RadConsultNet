using System;
using Microsoft.AspNetCore.Mvc;

namespace RadConsult.Controllers
{
    public class AboutController : Controller
    {
       public IActionResult Index()
        {
            return Content( "About Us Page");
        }
    }
}

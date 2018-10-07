using Microsoft.AspNetCore.Mvc;
using RadConsult.Models;

namespace RadConsult.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new Scan { Id = 1, Title = "MRI Scan", Description = "for Mrs XYZ" };
            return new ObjectResult(model);
        }
    }
}

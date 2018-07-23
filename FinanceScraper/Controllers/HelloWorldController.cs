using System.Text.Encodings.Web;
using Microsoft.AspNetCore.Mvc;

namespace FinanceScraper.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/
        // Requires using System.Text.Encodings.Web;

        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["ID"] = ID;

            return View();
        }
    }
}
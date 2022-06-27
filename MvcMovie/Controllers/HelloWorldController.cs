using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome
        public IActionResult Welcome(string name, int numTimes = 1) // Method(string name, int ID = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;

            return View();
            //return HtmlEncoder.Default.Encode(value: $"Hello {name}, ID: {ID}"); //HtmlEncoder.Default.Encode to protect the app from malicious input, such as through JavaScript.
        }
    }
}

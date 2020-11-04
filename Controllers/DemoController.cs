using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MVCNetCoreUbuntu.Controllers
{
    public class DemoController : Controller
    {
        // 
        // GET: /HelloWorld/

        public IActionResult Index()
        {
            return View("~/Views/Demo/Index.cshtml");
        }

        // 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome action method...";
        }
    }
}
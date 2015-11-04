using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{

    public class HelloWorldController : Controller
    {
        // Added this comment while practicing branching, pushing, and pullling
        // using the GitHub extension for VS
        // GET: HelloWorld

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /HelloWorld/Welcome/

        public ActionResult Welcome(string name, int numTimes = 1)
        {
            ViewBag.Message = "Hello " + name;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}
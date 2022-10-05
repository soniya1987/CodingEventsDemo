using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace coding_events_practice.Controllers
{
    public class EventsController : Controller
    {
        // GET: /<controller>/

        private static Dictionary<string, string> Events = new Dictionary<string, string>();

        public IActionResult Index()
        {

            Events.Add("Code With Pride", "Code With Pride");
            Events.Add("Apple WWDC", "Apple WWDC");
            Events.Add("Strange Loop", "Strange Loop");

            ViewBag.events = Events;

            return View();
        }
        
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("Events/Add")]
        public IActionResult NewEvent(string name, string desc)
        {
            Events.Add(name, desc);

            return Redirect("/Events");
        }
    }
}

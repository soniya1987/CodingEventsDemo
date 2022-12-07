using CodingEventsDemo.Data;
using CodingEventsDemo.Models;
using CodingEventsDemo.Viewmodels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace CodingEventsDemo.Controllers
{
    public class EventCategoryController : Controller
    {
        private EventDbContext context;
        public EventCategoryController(EventDbContext dbcontext)
        {
            context = dbcontext;
        }

        public IActionResult Index()
        {
            ViewBag.title = "All Categories";
            List<EventCategory> categories = context.Categories.ToList();
            return View(categories);
        }
        public IActionResult Create()
        {
            AddEventCategoryViewModel addEventCategoryViewModel = new AddEventCategoryViewModel();
            return View(addEventCategoryViewModel);
        }

        [HttpPost]
        [Route("EventCategory/Create")]
        public  IActionResult ProcessCreateEventCategoryForm(AddEventCategoryViewModel addEventCategoryViewModel)
        {
            if (ModelState.IsValid)
            {
                EventCategory category = new EventCategory();
                category.Name = addEventCategoryViewModel.Name;

                context.Categories.Add(category);
                context.SaveChanges();
                return Redirect("/EventCategory");
            }
            return View("EventCategory/Create", addEventCategoryViewModel);
        }
    }
}

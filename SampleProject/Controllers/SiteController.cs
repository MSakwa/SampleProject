using SampleProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SampleProject.Controllers
{
    public class SiteController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Edit(string id, int age)
        {
            return View(new InputData() { Name = id, Age = age });
        }

        [HttpPost]
        public ActionResult Edit(InputData vrpInput)
        {
            return RedirectToAction("Edit", "Site", new { id = vrpInput.Name, age = vrpInput.Age });
        }
    }
}
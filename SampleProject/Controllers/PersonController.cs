using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleProject.Utilities;
using SampleProject.Models;
using SampleProject.DAL;
using SampleProject.Models.ViewModels;

namespace SampleProject.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            using (DAL.ApplicationContext vrlContext = new DAL.ApplicationContext())
            {
                var vrlPersons = vrlContext.Persons.ToList();
                return View(vrlPersons);
            }
        }

        public ActionResult Edit(int id)
        {
            using (ApplicationContext vrlContext = new ApplicationContext())
            {
                Person person = vrlContext.Persons.FirstOrDefault(x => x.Id == id);
                PersonInput personVM = new PersonInput();
                personVM.Age = person.Age;
                personVM.FirstName = person.FirstName;
                personVM.LastName = person.LastName;
                personVM.Id = person.Id;
                return View("Edit", personVM);
            }
        }

        [HttpPost]
        public ActionResult Edit(PersonInput vrpInput)
        {
            using (ApplicationContext vrlContext = new ApplicationContext())
            {
                Person person = vrlContext.Persons.FirstOrDefault(x => x.Id == vrpInput.Id);
                person.Age = vrpInput.Age;
                person.FirstName = vrpInput.FirstName;
                person.LastName = vrpInput.LastName;

                vrlContext.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
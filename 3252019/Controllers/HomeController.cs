using _3252019.data;
using _3252019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3252019.Controllers
{
    public class HomeController : Controller
    {
        PeopleManager mgr = new PeopleManager(Properties.Settings.Default.ConStr);

        public ActionResult Index()
        {
            List<Person> people = mgr.GetPeople();
            return View(people);
        }

        public ActionResult AddPerson()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SubmitPerson(List<Person> people)
        {
            foreach(Person p in people)
            {
                mgr.SubmitPeople(p);
            }

            return Redirect("/home/index");
        }

    }
}
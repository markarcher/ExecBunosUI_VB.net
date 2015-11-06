using ExecBonusUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExecBonusUI.Controllers
{
    public class PersonController : Controller
    {
        //
        // GET: /Person/
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ExecBonus()
        {
            DateTime d1 = DateTime.Now;
            List<Person> persons = new List<Person>()
            {
                new Person {ID=1,FirstName="Craig", LastName="David",  Address="Dumaguete City", Date = d1},
                new Person {ID=2,FirstName="Mark", LastName="javier",  Address="Dumaguete City",Date = d1},
                new Person {ID=3,FirstName="juan", LastName="del cruz",  Address="Makati City",Date = d1},
                new Person {ID=4,FirstName="james", LastName="Playstead",  Address="Dumaguete City",Date = d1},
                new Person {ID=5,FirstName="mats", LastName="Javier",  Address="Dumaguete City",Date = d1},
                new Person {ID=6,FirstName="pauly", LastName="Del cruz",  Address="Makati City",Date = d1},
                new Person {ID=1,FirstName="solen", LastName="Yusef",  Address="Dumaguete City", Date = d1},
                new Person {ID=2,FirstName="Megan", LastName="Young",  Address="Dumaguete City",Date = d1},
                new Person {ID=3,FirstName="Zoren", LastName="Legazpi",  Address="Makati City",Date = d1},
                new Person {ID=4,FirstName="Fernando", LastName="alonso",  Address="Dumaguete City",Date = d1},
                new Person {ID=5,FirstName="Kimi", LastName="Raikkonen",  Address="Dumaguete City",Date = d1},
                new Person {ID=6,FirstName="paul", LastName="Del cruz",  Address="Makati City",Date = d1},
            };
            ViewBag.listOfPersons = persons;
            return View();
        }
	}
}
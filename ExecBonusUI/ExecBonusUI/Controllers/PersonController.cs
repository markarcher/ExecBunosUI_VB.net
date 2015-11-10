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
            string userName = "mark";
            ViewBag.name = userName;
            return View();
        }

        public ActionResult Login()
        {
            return View();
        }

        public ActionResult Home()
        {
            return View();
        }

        public ActionResult MainMenu()
        {
            return View();
        }

        public ActionResult PolicyMaster()
        {
            return View();
        }

        public ActionResult ExecBonus()
        {
            DateTime d1 = DateTime.Now;
            List<Person> persons = new List<Person>()
            {
                new Person {ID=01,FirstName="Craig", LastName="David",  Address="Dumaguete City", Date = d1},
                new Person {ID=02,FirstName="Mark", LastName="javier",  Address="Dumaguete City",Date = d1},
                new Person {ID=03,FirstName="juan", LastName="del cruz",  Address="Makati City",Date = d1},
                new Person {ID=04,FirstName="james", LastName="Playstead",  Address="Dumaguete City",Date = d1},
                new Person {ID=05,FirstName="mats", LastName="Javier",  Address="Dumaguete City",Date = d1},
                new Person {ID=06,FirstName="pauly", LastName="Del cruz",  Address="Makati City",Date = d1},
                new Person {ID=11,FirstName="solen", LastName="Yusef",  Address="Dumaguete City", Date = d1},
                new Person {ID=12,FirstName="Megan", LastName="Young",  Address="Dumaguete City",Date = d1},
                new Person {ID=13,FirstName="Zoren", LastName="Legazpi",  Address="Makati City",Date = d1},
                new Person {ID=14,FirstName="Fernando", LastName="alonso",  Address="Dumaguete City",Date = d1},
                new Person {ID=15,FirstName="Kimi", LastName="Raikkonen",  Address="Dumaguete City",Date = d1},
                new Person {ID=16,FirstName="paul", LastName="Del cruz",  Address="Makati City",Date = d1},
            };
            ViewBag.listOfPersons = persons;
            return View();
        }

        public ActionResult ActionMethodName(FormCollection collection)
        {
            
           
            return RedirectToAction("Index");
        }
	}
}
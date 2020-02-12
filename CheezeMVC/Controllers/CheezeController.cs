using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CheezeMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheezeMVC.Controllers
{
    public class CheezeController : Controller
    {

       // static private Dictionary<string, string> Cheeses = new Dictionary<string, string>();
       static public List<Cheeze> Cheezes = new List<Cheeze>();
       

       //public Cheeze cheeze { get; set; }
        public Cheeze cheeze = new Cheeze();
        public IActionResult Index()
        {
            ViewBag.cheezes = Cheezes;
            return View();
        }

        public IActionResult Add()
        {
            return View();
        }

        public IActionResult Remove()
        {
            ViewBag.cheezes = Cheezes;
            return View();
        }
        public IActionResult Remove2()
        {
            ViewBag.cheezes = Cheezes;
            return View();
        }

        [HttpPost]
        [Route("/Cheeze/Remove")]
        public IActionResult LessCheese(Cheeze cheeze)
        {
            //Take away the old cheeses from the list
            foreach (Cheeze item in cheeze.cheezelist)
            {
                Cheezes.Remove(item);
                
            }
            return Redirect("/Cheeze");

        }

        [HttpPost]
        [Route("/Cheeze/Add")]
        public IActionResult NewCheese(Cheeze cheeze)
        {

            //Add the new cheese to my existing cheeses
            Cheezes.Add(cheeze);

            return Redirect("/Cheeze");

        }
        [HttpPost]
        [Route("/Cheeze/Remove2")]
        public IActionResult RemoveOne(Cheeze cheeze)
        {
            //Take away one cheese from the list
            Cheezes.Remove(cheeze);
            return Redirect("/Cheeze");

        }


    }
}

using Sheet4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sheet4.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {

            List<SelectListItem> meals = new List<SelectListItem>();
            meals.Add(new SelectListItem { Text = "Pepperoni", Value = "Pepperoni"});

            meals.Add(new SelectListItem { Text = "Cheese", Value = "Cheese" });

            /*
            var model = new Order {

            }
            */

            return View();
        }


        public ActionResult Receipt()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection collection)
        {

            Dictionary<string, double> typePricesList = new Dictionary<string, double>()
            {
                {"Peperonie", 13.5 },
                {"Cheese", 12 },
                {"Alldress", 14 },
                {"Vege", 13.5 }

            };

            Dictionary<string, double> sizePricesList = new Dictionary<string, double>()
            {
                {"Small", 0 },
                {"Medium", 1 },
                {"Large", 2 },
                {"XLarge", 3 }

            };

            Dictionary<string, double> dealPricesList = new Dictionary<string, double>()
            {
                {"none", 0 },
                {"chips", 1 },
                {"cookies", 2 }
            };

            String typetest = collection["type"];

            double typePrice = typePricesList[collection["type"]];

            double sizePrice = sizePricesList[collection["size"]];

            double deal = dealPricesList[collection["deal"]];

            // Code for viewbag (output) 
            ViewBag.TypeName = collection["type"];
            ViewBag.SizeName = collection["size"];
            ViewBag.DealName = collection["deal"];
            ViewBag.TotalPizza = typePrice + sizePrice;
            ViewBag.TotalDeal = deal;

            double cost = typePrice + sizePrice+ deal;
            ViewBag.Cost = cost;
            double tax = cost * 0.15;
            ViewBag.Tax = tax;
            double total = cost + tax;
            ViewBag.Total = total; 





            return View("Receipt");
        }

        public enum subType
        {
            Peperonie, Cheese,  Alldress, Vege
        }

        public enum subSize
        {
            Small, Medium, Large, XLarge
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProductManagementSystem.Models;
using ProductManagementSystemData;

namespace ProductManagementSystem.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpGet]
        public ActionResult Store()
        {

            Store model = new Store();
            model.StateName = "ALL STATES";
            model.StoreItemList.Add(new Store()
                {
                    StoreID = 1,
                    StoreName = "Store A",
                    StateName = "State A"

                });
            model.StoreItemList.Add(new Store()
            {
                StoreID = 1,
                StoreName = "Store B",
                StateName = "State B"

            });
            return View(model);
        }

        [HttpGet]
        public ActionResult Home()
        {

           
            return View();
        }

    }
}

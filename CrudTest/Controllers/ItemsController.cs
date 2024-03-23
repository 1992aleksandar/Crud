using CrudTest.Models;
using System;
// ItemsController.cs
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace CrudTest.Controllers
{


    public class ItemsController : Controller
    {
        private static List<Item> items = new List<Item>();

        
        public ActionResult Index()
        {
            // Add a cookie
            Response.Cookies["MyCookie"].Value = "cookie_value";
            Response.Cookies["MyCookie"].Expires = DateTime.Now.AddDays(1); // Set expiration
            Item item = new Item { Description = "description", Id = 1, Name = "name" };
            return View("Items", item);
        }

    }

}

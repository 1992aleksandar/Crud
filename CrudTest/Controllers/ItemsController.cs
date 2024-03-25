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
            //setting cookie from backend
            Response.Cookies["CookieFromBackend"].Value = "cookie_value";
            Response.Cookies["CookieFromBackend"].Expires = DateTime.Now.AddDays(1); // Set expiration
            Response.Cookies["CookieFromBackend"].Secure = true;
            Response.Cookies["CookieFromBackend"].HttpOnly = true;
            Item item = new Item { Description = "description", Id = 1, Name = "name" };
            return View("Items", item);
        }

        public string Get()
        {
            return "ok";
        }

    }

}

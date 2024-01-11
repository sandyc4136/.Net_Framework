using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_7.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //public IActionResult DemoRazor()
        //{
        //    //ViewData

        //    ViewData["title"] = "My First Page";
        //    ViewData["Name"] = "Sandip Chhetry";
        //    ViewData["Address"] = new Address { Id = 2, StreetName = "Juhu STreet", City = "Bandra" };
        //    //ViewBag

        //    ViewBag.Name = "Sandip ";
        //    ViewBag.Message = "Hello ";
        //    ViewBag.Desc = "GoodBye";
        //    ViewBag.Address = new Address()
        //    {
        //        Id = 1,
        //        StreetName = "Defcol",
        //        City = "Delhi"
        //    };
        //    return View();

        //}

        //public IActionResult ShowDetails()
        //{
        //    ViewBag.FName = "Ashok";
        //    ViewBag.LName = "Lamba";
        //    ViewBag.Add1 = new Address { City = "Mumbai", Id = 102, StreetName = "Juhu Street" };
        //    return View();
        //}

        public IActionResult PartialDemo()
        {
            return PartialView();
        }

        public IActionResult MyMethod()
        {
            return View();
        }
    }

    
} 
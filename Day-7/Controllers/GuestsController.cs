using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day_7.Data;
using Day_7.Models;
using Microsoft.AspNetCore.Mvc;

namespace Day_7.Controllers
{
    public class GuestsController : Controller
    {
        private MyDbContext _dbContext;

        public GuestsController(MyDbContext context)
        {
            _dbContext = context;
        }

        public IActionResult Index()
        {
            var guests = _dbContext.Guests.ToList();
            return View(guests);
        }

        //[HttpGet]
        public IActionResult GuestsList()
        {
            var guests=_dbContext.Guests;
            return View(guests);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Guests guest)
        {
            _dbContext.Guests.Add(guest);
            _dbContext.SaveChanges();
            return RedirectToAction("GuestsList");
        }
    }
}
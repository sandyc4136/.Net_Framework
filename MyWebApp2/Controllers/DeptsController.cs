using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebApp2.Data;
using MyWebApp2.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebApp2.Controllers
{
    public class DeptsController : Controller
    {
        private MyDbContext _context;
        public DeptsController(MyDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var depts = _context.Depts.ToList();
            return View(depts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Dept dept)
        {
            //  person.Name = "CDAC";   
            _context.Depts.Add(dept);  //Database
            _context.SaveChanges();//  Commit
            return Redirect("Index");
        }
    }
}


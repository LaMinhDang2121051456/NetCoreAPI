
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers;


    public class PersonController : Controller
    {
        // Action 1: Trả về View Index
        public IActionResult Index()
        {
            ViewBag.Id = 1;
            ViewBag.Name = "Vu Linh";
            ViewBag.Age = 30;
            return View();
        }

        // Action 2: Trả về View Details
        public IActionResult Details()
        {
            ViewBag.Id = 2;
            ViewBag.Name = "Nguyen Van A";
            ViewBag.Age = 25;
            return View();
        }

        
    }



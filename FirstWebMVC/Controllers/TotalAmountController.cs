using System;
using System.Text.RegularExpressions;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;


namespace FirstWebMVC.Controllers
{
    public class TotalAmountController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Calculate(int? qtyMiGoi, int? qtyWater, int? qtyCigarette)
        {
            int mygoi = qtyMiGoi ?? 0;
            int water = qtyWater ?? 0;
            int cigarette = qtyCigarette ?? 0;

            var products = new List<Product>
            {
                new Product { ProductID = "Mỳ gói", Quantity = mygoi, UnitPrice = 5000 },
                new Product { ProductID = "Nước đóng chai", Quantity = water, UnitPrice = 10000 },
                new Product { ProductID = "Thuốc lá", Quantity = cigarette, UnitPrice = 25000 }
            };

            //tong hoa don
            double TotalAmount = (mygoi*5000) + (water*10000) + (cigarette*25000);

            //gui  qua ViewBag
            ViewBag.TotalAmount = TotalAmount;
            return View(products);


        }
             
    }
}
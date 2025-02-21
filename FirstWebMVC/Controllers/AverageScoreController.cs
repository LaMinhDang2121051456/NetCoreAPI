using System;
using System.Text.RegularExpressions;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;


namespace FirstWebMVC.Controllers
{
    public class AverageScore : Controller
    {
        [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(String Ascore, String Bscore, String Cscore, String SubjectName)
    {
        if (string.IsNullOrWhiteSpace(SubjectName) || string.IsNullOrWhiteSpace(Ascore) || string.IsNullOrWhiteSpace(Bscore) || string.IsNullOrWhiteSpace(Cscore)) 
        {
            ViewBag.Error = "ten mon hoc khong duoc trong!";
            return View(); 
        }
        //kiem tra so hop le hay khomg(tu 0 den 10, 2 so thap phan)
        string pattern = @"^\d+(\.\d{1,2})?$";
        if (!Regex.IsMatch(Ascore, pattern) ||
            !Regex.IsMatch(Bscore, pattern) ||
            !Regex.IsMatch(Cscore, pattern)) 
            {
                ViewBag.Error = "Diem invalid, diem nam tu 0 den 10, toi da 2 so thap phan!";
                return View("Index");
            }
        //chuyen sang so thuc 
        double a = double.Parse(Ascore);
        double b = double.Parse(Bscore);
        double c = double.Parse(Cscore);  

        //kiem tra diem co hop le ko 
        if (a < 0 || a > 10 || b < 0 || b > 10 || c < 0 || c > 10)
        {
        ViewBag.Error = "diem phai nam trong khoang tu 0 den 10!";
        return View("Index");   
        }

        //tinh diem theo cthuc 0.6a + 0.3b + 0.1c
        double average = (a*0.6)+ (b*0.3)+(c*0.1);

        //truyen du lieu sang view
        ViewBag.SubjectName = SubjectName;  
        ViewBag.Average = $"Diem cua mon {SubjectName}: {average:F2}";

        return View("Result");
    }
    }
}
using System.Net;

using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;
namespace FirstWebMVC.Controllers
{
    public class BMIController : Controller
    {
        [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Calculate(double weight, double height)
    {
        if (height <= 0 || weight <= 0)
        {
            ViewBag.Error = "Chiều cao và cân nặng phải lớn hơn 0.";
            return View("Index");
        }

        BMI bmiModel = new BMI
        {
            weight = weight,
            height = height,
            BMIScore = weight / (height * height) // Công thức tính BMI
        };

        return View("Result", bmiModel);
    }

    }
}

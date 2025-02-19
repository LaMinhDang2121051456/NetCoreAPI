using System.Text.RegularExpressions;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;


namespace FirstWebMVC.Controllers
{
    public class AverageScore : Controller
    {
        [HttpGet]
    public IActivationResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActivationResult Calculate(double Ascore, double Bscore, double Cscore, double TotalScore)
    {
        if ()
    }
    }
}
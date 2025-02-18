using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using FirstWebMVC.Models;

namespace FirstWebMVC.Controllers
{
    public class EmployeeController : Controller
    {
        // Action 1: Trả về View Index
        public IActionResult Index()
        {
            // Tạo danh sách nhân viên
            var employees = new List<Employee>
            {
                new Employee(1, "Dang", "HR"),
                new Employee(2, "Minh", "IT"),
                new Employee(3, "La", "Finance")
            };

            // Gửi danh sách qua ViewBag
            ViewBag.Employees = employees;
            return View();
        }

        // Action 2: Trả về View Profile
        public IActionResult Profile()
        {
            // Tạo một đối tượng Employee
            var employee = new Employee(4, "Vu Linh", "IT");

            // Gửi đối tượng qua ViewBag
            ViewBag.Employee = employee;
            return View();
        }
    }
}

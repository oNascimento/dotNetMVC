using System.Linq;
using authorizationSample.Data;
using authorizationSample.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace authorizationSample.Controllers
{
    [Authorize]
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext context;

        public EmployeeController(ApplicationDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var emps = context.Employees.ToList();
            return View(emps);
        }
         [HttpGet]
        public IActionResult Create() { 
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee model) { 
            if (!ModelState.IsValid) return View(model);
            context.Add(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Edit(long? id) { 
            var emp = context.Employees.Find(id);
            return View(emp);
        }

        [HttpPost]
        public IActionResult Edit(Employee model) { 
            if (!ModelState.IsValid) return View(model);
            context.Employees.Update(model);
            context.SaveChanges();
            return RedirectToAction("index");
        }
        [HttpGet]
        public IActionResult Delete(long? id){ 
           var emp = context.Employees.Find(id);
           context.Employees.Remove(emp);
           context.SaveChanges();
           return RedirectToAction("index");
        }
    }
}
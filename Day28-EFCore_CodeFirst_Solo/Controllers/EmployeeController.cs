using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day28_EFCore_CodeFirst_Solo.Context;
using Microsoft.AspNetCore.Mvc;

namespace Day28_EFCore_CodeFirst_Solo.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly CompanyDbContext _context;

        public EmployeeController(CompanyDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id)
        {
            return View(_context.Employees.ToList());
        }

        [HttpGet]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddEmployee(Employee employee)
        {
            employee.DepartmentId = 1;
            if(ModelState.IsValid)
            {
                _context.Employees.Add(employee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        public IActionResult DeleteEmployee(int id)
        {
            Employee foundEmployee = _context.Employees.Find(id);
            if(foundEmployee != null)
            {
                _context.Remove(foundEmployee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult EditEmployee(int id)
        {
            Employee foundEmployee = _context.Employees.Find(id);
            if(foundEmployee != null)
            {
                return View(foundEmployee);
            }
            return RedirectToAction("Index");           
        }

        [HttpPost]
        public IActionResult EditEmployee(Employee updatedEmployee)
        {
            Employee dbEmployee = _context.Employees.Find(updatedEmployee.Id);
            if(ModelState.IsValid)
            {
                dbEmployee.FirstName = updatedEmployee.FirstName;
                dbEmployee.LastName = updatedEmployee.LastName;
                dbEmployee.Email = updatedEmployee.Email;

                _context.Entry(dbEmployee).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(dbEmployee);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
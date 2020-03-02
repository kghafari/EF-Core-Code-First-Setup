using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day28_EFCore_CodeFirst_Solo.Context;
using Microsoft.AspNetCore.Mvc;

namespace Day28_EFCore_CodeFirst_Solo.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly CompanyDbContext _context;

        public DepartmentController(CompanyDbContext context)
        {
            _context = context;
        }

        //list(Read) departments
        public IActionResult Index()
        {
            return View(_context.Departments.ToList());
        }

        //add new department
        [HttpGet]
        public IActionResult AddDepartment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddDepartment(Department newDepartment)
        {
            if(ModelState.IsValid)
            {
                _context.Departments.Add(newDepartment);
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        //edit department
        [HttpGet]
        public IActionResult EditDepartment(int id)
        {
            Department foundDept = _context.Departments.Find(id);
            if(foundDept != null)
            {
                return View(foundDept);
            }
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult EditDepartment(Department updatedDepartment)
        {
            Department dbDepartment = _context.Departments.Find(updatedDepartment.Id);
            if(ModelState.IsValid)
            {
                dbDepartment.Name = updatedDepartment.Name;
                dbDepartment.Location = updatedDepartment.Location;
                dbDepartment.Type = updatedDepartment.Type;
                dbDepartment.Budget = updatedDepartment.Budget;

                _context.Entry(dbDepartment).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                _context.Update(dbDepartment);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

        //delete department - gotta do extra shit
        public IActionResult DeleteDepartment(int id)
        {
            Department foundDepartment = _context.Departments.Find(id);
            if(foundDepartment != null)
            {
                List<Employee> thisDepartmentsEmployees = _context.Employees.Where(x => x.DepartmentId == foundDepartment.Id).ToList();
                if(thisDepartmentsEmployees != null)
                {
                    foreach(Employee employee in thisDepartmentsEmployees)
                    {
                        employee.DepartmentId = null;
                    }
                }
                _context.Departments.Remove(foundDepartment);
                _context.SaveChanges();
            }
            return RedirectToAction("Index");
        }

    }
}
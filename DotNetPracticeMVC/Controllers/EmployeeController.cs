using DotNetPracticeMVC.Models;
using DotNetPracticeMVC.Services;
using Microsoft.AspNetCore.Mvc;

namespace DotNetPracticeMVC.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService employeeService;
        public EmployeeController(IEmployeeService employeeService)
        {
            this.employeeService = employeeService;

        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult getAllEmployees() 
        {
            List<Employees> emp = employeeService.getAllEmp();
            ViewData["data1"]=(emp);
            return View();
        }
        [HttpGet]
        public IActionResult getByID()
        {
            return View();
        }


        [HttpPost]
        public IActionResult getByID(int id)
        {
            Employees emp = employeeService.getEmp(id);
            ViewData["data2"] = (emp);
            return View();
        }

        [HttpGet]
        public IActionResult deleteEmp()
        {
            return View();
        }

        [HttpPost]

        public IActionResult deleteEmp(int id)
        {
            employeeService.deleteEmp(id);
            return RedirectToAction("Index","Home");
        }
        [HttpGet]
        public IActionResult addEmp()
        {
            return View();
        }

        [HttpPost]

        public IActionResult addEmp(string name, string job, double salary, int age, int accountNo)
        {
            Employees emp=new Employees(name,job,salary,age,accountNo);
            employeeService.addEmp(emp);
            return View();
        }

        [HttpGet]
        public IActionResult updateEmp()
        {
            return View();
        }

        [HttpPost]
        public IActionResult updateEmp(int id,string name,string job,double salary,int age,int accountNo)
        {
            Employees emp=new Employees(id,name,job,salary, age,accountNo);
            employeeService.updateEmp(emp);
            return RedirectToAction("Index", "Home");
        }
    }
}

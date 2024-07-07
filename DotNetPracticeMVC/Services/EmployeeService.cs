using DotNetPracticeMVC.Models;
using DotNetPracticeMVC.Repositories;

namespace DotNetPracticeMVC.Services
{
    public class EmployeeService:IEmployeeService
    {
        private IEmployeeManager employeeManager=new EmployeeManager();


        public List<Employees> getAllEmp()
        {
            return employeeManager.getAllEmployees();
        }
        public Employees getEmp(int id)
        {
            return employeeManager.getEmployees(id);
        }

        public void deleteEmp(int id) 
        { 
            employeeManager.deleteEmployees(id);
        }

       
        public void updateEmp(Employees employees)
        {
            employeeManager.updateEmployees(employees);
        }

        public void addEmp(Employees employees)
        {
            employeeManager.addEmployees(employees);
        }

       
        
    }
}

using DotNetPracticeMVC.Models;

namespace DotNetPracticeMVC.Repositories
{
    public class EmployeeManager : IEmployeeManager
    {
        public void addEmployees(Employees employees)
        {
            using (var context = new CollectionContext())
            {
                context.Employee.Add(employees);
                context.SaveChanges();
            }
        }

        public void deleteEmployees(int id)
        {
            using (var context = new CollectionContext())
            {
                context.Employee.Remove(context.Employee.Find(id));
                context.SaveChanges();
            }
        }

        public List<Employees> getAllEmployees()
        {
            using(var context = new CollectionContext())
            {
                var emp=from p in context.Employee select p;
                return emp.ToList<Employees>();
            }  
        }

        public Employees getEmployees(int id)
        {
            using (var context = new CollectionContext())
            {
                return context.Employee.Find(id);
            }
        }

        public void updateEmployees(Employees employees)
        {
            using (var context = new CollectionContext()) { 
                var emp=context.Employee.Find(employees.Id);
                emp.Name= employees.Name;
                emp.Job= employees.Job;
                emp.Salary= employees.Salary;
                emp.Age= employees.Age;
                emp.AccountNo= employees.AccountNo;
                context.SaveChanges();
            }
        }
    }
}

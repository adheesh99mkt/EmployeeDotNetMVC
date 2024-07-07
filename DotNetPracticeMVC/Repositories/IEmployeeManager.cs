using DotNetPracticeMVC.Models;

namespace DotNetPracticeMVC.Repositories
{
    public interface IEmployeeManager
    {
        List<Employees> getAllEmployees();
        Employees getEmployees(int id);
        void deleteEmployees(int id);
        void updateEmployees(Employees employees);
        void addEmployees(Employees employees);
    }
}

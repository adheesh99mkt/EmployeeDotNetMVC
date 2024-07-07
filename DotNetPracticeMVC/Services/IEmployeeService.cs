using DotNetPracticeMVC.Models;

namespace DotNetPracticeMVC.Services
{
    public interface IEmployeeService
    {
        List<Employees> getAllEmp();
        Employees getEmp(int id);
        void deleteEmp(int id);
        void updateEmp(Employees employees);
        void addEmp(Employees employees);



    }
}

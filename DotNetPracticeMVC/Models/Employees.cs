namespace DotNetPracticeMVC.Models
{
    public class Employees
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Job { get; set; }
        public double? Salary { get; set; }
        public int Age { get; set; }
        public int AccountNo { get; set; }
        public Employees() { }

        //for updating employees
        public Employees(int id, string? name, string? job, double? salary, int age, int accountNo)
        {
            Id = id;
            Name = name;
            Job = job;
            Salary = salary;
            Age = age;
            AccountNo = accountNo;
        }

        //for adding employees
        public Employees( string? name, string? job, double? salary, int age, int accountNo)
        {
           
            Name = name;
            Job = job;
            Salary = salary;
            Age = age;
            AccountNo = accountNo;
        }
    }
}

using System;
using System.Security.Cryptography.X509Certificates;
using System.Linq;
public class Task6
{
    class Employee
    {
        private string name;
        private double salary;
        private string position;
        private string department;
        private string email;
        private int age;

        public string Name { get; set; }
        public double Salary { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }

        public Employee(string name, double salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = "n/a";
            this.Age = -1;
        }
    }
    class Department
    {
        public string name;
        public List<Employee> employees;

        public Department(string name)
        {
            this.name = name;
            this.employees = new List<Employee>();
        }
    }
    public static void Main()
    {
        var depart = new List<Department>();
        
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var list_fill = Console.ReadLine().Split();
            string name = list_fill[0];
            double salary = double.Parse(list_fill[1]);
            string position = list_fill[2];
            string department = list_fill[3];
            string email = list_fill[4];
            int age = int.Parse(list_fill[5]);

            if (!depart.Any(d => d.name == department))
            {
                var dep = new Department(department);
                depart.Add(dep);
            }
        }
    }
}
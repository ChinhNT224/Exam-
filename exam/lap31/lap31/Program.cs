using System;

namespace EmployeeApp
{
    class Employee
    {
        private int id;
        private string name;
        private int yearOfBirth;
        private double salaryLevel;
        private static double basicSalary; // lương cơ bản

        public Employee(int id, string name, int yearOfBirth, double salaryLevel)
        {
            this.id = id;
            this.name = name;
            this.yearOfBirth = yearOfBirth;
            this.salaryLevel = salaryLevel;
        }

        public double GetIncome()
        {
            return salaryLevel * basicSalary;
        }

        public void Display()
        {
            Console.WriteLine("Employee ID: {0}", id);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Year of Birth: {0}", yearOfBirth);
            Console.WriteLine("Basic Salary: {0}", basicSalary);
            Console.WriteLine("Income: {0}", GetIncome());
        }

        public static double BasicSalary
        {
            get { return basicSalary; }
            set { basicSalary = value; }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee.BasicSalary = 1000; // thiết lập lương cơ bản cho mọi đối tượng của lớp Employee

            Employee emp1 = new Employee(1, "John Smith", 1985, 2.5);
            Employee emp2 = new Employee(2, "Mary Johnson", 1990, 3.0);

            emp1.Display();
            Console.WriteLine();
            emp2.Display();

            Console.ReadKey();
        }
    }
}

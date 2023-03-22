using System;

class Employee
{
    public int id { get; set; }
    public string name { get; set; }
    public int age { get; set; }

    public Employee(int id, string name, int age)
    {
        this.id = id;
        this.name = name;
        this.age = age;
    }

    public void Display()
    {
        Console.WriteLine("Id = {0}, Name = {1}, Age = {2}", id, name, age);
    }
}

class Department
{
    private string name;
    private Employee[] employees;

    public Department(string name, int size)
    {
        this.name = name;
        employees = new Employee[size];
        for (int i = 0; i < size; i++)
        {
            employees[i] = null;
        }
    }

    public Employee this[int index]
    {
        get
        {
            return employees[index];
        }
        set
        {
            employees[index] = value;
        }
    }

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Department department = new Department("Sales", 3);

        department[0] = new Employee(1, "John", 30);
        department[1] = new Employee(2, "Jane", 25);
        department[2] = new Employee(3, "Bob", 35);

        Console.WriteLine("Department Name: {0}", department.Name);
        Console.WriteLine("Employees:");
        for (int i = 0; i < 3; i++)
        {
            department[i].Display();
        }

        Console.ReadKey();
    }
}


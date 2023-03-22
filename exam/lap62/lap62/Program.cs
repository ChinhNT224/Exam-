using System;

// Tạo lớp ngoại lệ tự định nghĩa InvalidMarkException.
public class InvalidMarkException : Exception
{
    public InvalidMarkException(string message) : base(message)
    {
    }
}

// Tạo lớp Student với các thông tin (id, name , theorymark, labmark).
public class Student
{
    // Tạo thuộc tính cho các thông tin trên.
    public int Id { get; set; }
    public string Name { get; set; }
    private double _theoryMark;
    private double _labMark;

    public double TheoryMark
    {
        get { return _theoryMark; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new InvalidMarkException("Theory mark must be between 0 and 10.");
            }
            _theoryMark = value;
        }
    }

    public double LabMark
    {
        get { return _labMark; }
        set
        {
            if (value < 0 || value > 10)
            {
                throw new InvalidMarkException("Lab mark must be between 0 and 10.");
            }
            _labMark = value;
        }
    }

    // Tạo constructor cho lớp Student.
    public Student(int id, string name, double theoryMark, double labMark)
    {
        Id = id;
        Name = name;
        TheoryMark = theoryMark;
        LabMark = labMark;
    }
}

// Test các ngoại lệ trên.
class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Test InvalidMarkException.
            var student1 = new Student(1, "John", 11, 7);
            var student2 = new Student(2, "Mary", 9, -1);
        }
        catch (InvalidMarkException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.ReadKey();
    }
}

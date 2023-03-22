using System;
using System.Collections.Generic;

namespace CarList
{
    class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public Car(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo một List lưu trữ danh sách 10 Car
            List<Car> cars = new List<Car>()
            {
                new Car("Honda", "Red"),
                new Car("Toyota", "Blue"),
                new Car("Ford", "Green"),
                new Car("Chevrolet", "Red"),
                new Car("BMW", "Black"),
                new Car("Audi", "White"),
                new Car("Mercedes", "Red"),
                new Car("Lexus", "Silver"),
                new Car("Nissan", "Red"),
                new Car("Kia", "Yellow")
            };

            // Xóa các Car có màu Red
            cars.RemoveAll(car => car.Color == "Red");

            // In danh sách các Car
            Console.WriteLine("Danh sách các Car sau khi xóa các Car có màu Red:");
            foreach (var car in cars)
            {
                Console.WriteLine("{0} - {1}", car.Name, car.Color);
            }
        }
    }
}


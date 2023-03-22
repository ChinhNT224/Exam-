using System;

namespace GenericClassDemo
{
    class MyArray<T>
    {
        private T[] array;

        public MyArray(int size)
        {
            array = new T[size];
        }

        public void SetValue(int index, T value)
        {
            array[index] = value;
        }

        public T GetValue(int index)
        {
            return array[index];
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Tạo một MyArray với 5 phần tử kiểu int
            MyArray<int> myIntArray = new MyArray<int>(5);

            // Thêm giá trị vào MyArray
            myIntArray.SetValue(0, 1);
            myIntArray.SetValue(1, 2);
            myIntArray.SetValue(2, 3);
            myIntArray.SetValue(3, 4);
            myIntArray.SetValue(4, 5);

            // Lấy giá trị từ MyArray và in ra màn hình
            Console.WriteLine("Các giá trị trong MyArray kiểu int:");
            Console.WriteLine(myIntArray.GetValue(0));
            Console.WriteLine(myIntArray.GetValue(1));
            Console.WriteLine(myIntArray.GetValue(2));
            Console.WriteLine(myIntArray.GetValue(3));
            Console.WriteLine(myIntArray.GetValue(4));

            // Tạo một MyArray với 3 phần tử kiểu string
            MyArray<string> myStringArray = new MyArray<string>(3);

            // Thêm giá trị vào MyArray
            myStringArray.SetValue(0, "Hello");
            myStringArray.SetValue(1, "World");
            myStringArray.SetValue(2, "!");

            // Lấy giá trị từ MyArray và in ra màn hình
            Console.WriteLine("\nCác giá trị trong MyArray kiểu string:");
            Console.WriteLine(myStringArray.GetValue(0));
            Console.WriteLine(myStringArray.GetValue(1));
            Console.WriteLine(myStringArray.GetValue(2));
        }
    }
}


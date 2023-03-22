using System;

namespace GenericMethodDemo
{
    class Program
    {
        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            // Hoán vị 2 giá trị kiểu int
            int x = 1;
            int y = 2;
            Console.WriteLine("Trước khi hoán vị: x = {0}, y = {1}", x, y);
            Swap(ref x, ref y);
            Console.WriteLine("Sau khi hoán vị: x = {0}, y = {1}", x, y);

            // Hoán vị 2 giá trị kiểu string
            string s1 = "Hello";
            string s2 = "World";
            Console.WriteLine("\nTrước khi hoán vị: s1 = {0}, s2 = {1}", s1, s2);
            Swap(ref s1, ref s2);
            Console.WriteLine("Sau khi hoán vị: s1 = {0}, s2 = {1}", s1, s2);
        }
    }
}

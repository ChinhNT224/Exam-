using System;

namespace AnonymousMethodExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // Kiểm tra số nguyên tố
            Func<int, bool> isPrime = delegate (int n)
            {
                if (n < 2) return false;
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0) return false;
                }
                return true;
            };

            int number = 7;
            if (isPrime(number))
            {
                Console.WriteLine($"{number} là số nguyên tố");
            }
            else
            {
                Console.WriteLine($"{number} không là số nguyên tố");
            }

            // Tính tổng các số từ n đến m
            Func<int, int, int> sum = delegate (int n, int m)
            {
                int result = 0;
                for (int i = n; i <= m; i++)
                {
                    result += i;
                }
                return result;
            };

            int n = 1, m = 10;
            int total = sum(n, m);
            Console.WriteLine($"Tổng các số từ {n} đến {m} là {total}");

            Console.ReadKey();
        }
    }
}

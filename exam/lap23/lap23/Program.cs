using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Các số tổng 3 ký số chẵn từ 100-999 là:");

            for (int i = 100; i <= 999; i++)
            {
                int sum = (i / 100) + ((i / 10) % 10) + (i % 10);
                if (sum % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }

            Console.ReadLine();
        }
    }
}

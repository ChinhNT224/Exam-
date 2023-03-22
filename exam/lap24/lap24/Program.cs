using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập chiều cao của tam giác: ");
            int height = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height; i++)
            {
                for (int j = 1; j <= height - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            Console.Write("Nhập chiều cao của tam giác: ");
            int height1 = int.Parse(Console.ReadLine());

            for (int i = height1; i >= 1; i--)
            {
                for (int j = 1; j <= height1 - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
            }

            Console.ReadLine();

            Console.Write("Nhập chiều cao của tam giác: ");
            int height2 = int.Parse(Console.ReadLine());

            for (int i = 1; i <= height2; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập 3 số nguyên a, b, c:");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("a, b, c tạo thành 3 cạnh của một tam giác");
                if (a == b && b == c)
                {
                    Console.WriteLine("Tam giác đều");
                }
                else if (a == b || a == c || b == c)
                {
                    Console.WriteLine("Tam giác cân");
                }
                else if (a * a + b * b == c * c || a * a + c * c == b * b || b * b + c * c == a * a)
                {
                    Console.WriteLine("Tam giác vuông");
                }
                else
                {
                    Console.WriteLine("Tam giác thường");
                }
            }
            else
            {
                Console.WriteLine("a, b, c không tạo thành 3 cạnh của một tam giác");
            }

            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập năm: ");
            int year = int.Parse(Console.ReadLine());

            Console.Write("Nhập tháng: ");
            int month = int.Parse(Console.ReadLine());

            int daysInMonth = DateTime.DaysInMonth(year, month);
            Console.WriteLine("Số ngày trong tháng {0}/{1} là {2}", month, year, daysInMonth);

            Console.ReadLine();
        }
    }
}


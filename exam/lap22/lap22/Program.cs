using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhập số giây: ");
            int totalSeconds = int.Parse(Console.ReadLine());

            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            Console.WriteLine("{0:D2}:{1:D2}:{2:D2}", hours, minutes, seconds);

            Console.ReadLine();
        }
    }
}

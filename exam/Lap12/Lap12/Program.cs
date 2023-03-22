using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Lap12
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            string id, name, adress;
            DateTime birthday;
            double salary, bonus;
            Console.WriteLine("Nhap vao ma nhan vien: ");
            id= Console.ReadLine();
            Console.WriteLine("Nhap vao ten: ");
            name= Console.ReadLine();
            Console.WriteLine("Nhap vao dia chi: ");
            adress= Console.ReadLine();
            Console.WriteLine("Nhap vao ngay sinh: ");
            birthday=Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Nhap vao luong: ");
            salary= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Nhap vao thuong: ");
            bonus= Convert.ToDouble(Console.ReadLine());
            double Totalsalary = salary + bonus;
            Console.WriteLine("Thong tin nhan vien /n");
            Console.WriteLine("Ma nhan vien:{0} ", id);
            Console.WriteLine("Ten nhan vien:{0} ", name);
            Console.WriteLine("Dia chi nhan vien:{0} ", adress);
            Console.WriteLine("Ngay sinh nhan vien:{0: dd/MM/yyyy} ", birthday);
            Console.WriteLine("Luong nhan vien:{0} ", Totalsalary);
        }
    }
}

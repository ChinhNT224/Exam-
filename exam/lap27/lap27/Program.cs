using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lap27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhập số tiền gửi:");
            double tienGui = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập lãi suất ngân hàng (%):");
            double laiSuatNam = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhập số tháng gửi:");
            int soThangGui = int.Parse(Console.ReadLine());

            double laiSuatThang = (laiSuatNam / 12) / 100;
            double tienLaiThang = tienGui * laiSuatThang;

            for (int i = 0; i < soThangGui; i++)
            {
                tienGui += tienLaiThang;
            }

            double tienLaiCuoiKy = tienGui - (tienGui / (1 + laiSuatThang) - tienGui);

            Console.WriteLine("Số dư cuối kỳ: {0:N}", tienGui);
            Console.WriteLine("Tiền lãi cuối kỳ: {0:N}", tienLaiCuoiKy);

            Console.ReadLine();
        }
    }
}

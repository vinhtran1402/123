using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hinh_Tam_Giac
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap canh a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh b");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap canh c");
            double c = double.Parse(Console.ReadLine());
            double chuvi = a + b + c;
            double P= chuvi / 2;
            double dientich =
                Math.Sqrt(P * (P - a) * (P - b) * (P - c));
            Console.WriteLine("CV la: {0}, DT la: {1}", chuvi, dientich);
            Console.ReadKey();

        }
    }
}

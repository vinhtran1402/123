using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phuong_Trinh_Bat_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C");
            double c = double.Parse(Console.ReadLine());
            double d = b * b - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("{0}X^2 + {1}X + {2} = 0", a,b,c);
                Console.WriteLine("X1={0}, X2={1}", x1, x2);
            }

            Console.ReadKey();
        }
    }
}

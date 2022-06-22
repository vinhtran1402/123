using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Xep_Loai_Hoc_Tap
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap Diem");
        double diem = double.Parse(Console.ReadLine());
            if (diem >= 0 && diem < 3.5)
            {
                Console.WriteLine("kem");
            }
            if (diem >=3.5 && diem <5)
            {
                Console.WriteLine("yeu");

            }
            if (diem >= 5 && diem < 6.5)
            {
                Console.WriteLine("trung binh");

            }
            if (diem >= 6 && diem < 8.5)
            {
                Console.WriteLine("kha");

            }
            if (diem >= 8.5 && diem <= 10)
            {
                Console.WriteLine("gioi");

            }

            if (diem <3.5)
            { Console.WriteLine("kem");
            }
            else if (diem <5)
               { Console.WriteLine("yeu");
            }
            else if (diem < 6.5)
            { Console.WriteLine("trung binh");
            }
            else if (diem < 8.5)
            { Console.WriteLine("kha");
            }
        else
            { Console.WriteLine("gioi");
            }
            
}

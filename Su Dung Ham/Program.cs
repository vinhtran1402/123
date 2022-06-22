using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Su_Dung_Ham
{
    class Program
    {
        static void Main(string[] args)
        {


            menu();







        }

        private static void menu()
        {
            Console.WriteLine("=====Menu=====");
            Console.WriteLine("1.Phuong trinh bac 1");
            Console.WriteLine("2.Phuong trinh bat 2");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    Phuongtrinhbat1();
                    break;
                case "2":
                    Phuongtrinhbat2();
                    break;
                case "exit":
                    return;
            }
            menu();
        }

        private static void Phuongtrinhbat2()
        {
            Console.WriteLine("Nhap A:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap B:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap C:");
            double c = double.Parse(Console.ReadLine());
            double d = Math.Pow(b, 2) - 4 * a * c;
            try
            {
                if (d < 0)
                {
                    throw new Exception("Vo nghiem");
                    double x1 = (-b + Math.Sqrt(d)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("X1={0}, X2{1}", x1, x2);
                }
            }
            catch (Exception ex)


            {
                Console.WriteLine(ex.Message);

            }


        }









        private static void Phuongtrinhbat1()
        {
            Console.WriteLine("Nhap so A");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap so B");
            double b = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("VSN");
                }
                else
                {
                    Console.WriteLine("VN");
                }
            }
            else
            {
                Console.WriteLine("X = {0:f2}", -b / a);
            }

        }











        private static void Xinchao(string hoten)
        {
            Console.WriteLine("Xin chao: {0}", hoten);
        }

        private static void Xinchao()
        {
            Console.WriteLine("Xinchao");
        }
    }
}

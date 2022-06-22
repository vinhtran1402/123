using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so a");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so b");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so c");
            int c = int.Parse(Console.ReadLine());

            int max = a;
            if (max < b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine("So Lon Nhat La: {0}", max);

            Console.ReadKey();
            int min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine("So Nho Nhat La: {0}", min);
            Console.ReadKey();

            int max2 = a , a 

            if (max2 < b)
            {
                max2 = b;
            }
            if (max2 < c)
            {
                max2 = c;
            }
            Console.WriteLine("So Lon Thu 2 La: {0}", max2);
            Console.ReadKey();




        }
    }
}

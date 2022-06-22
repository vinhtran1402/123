using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ngoai_Le
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap So Nguyen A");
                int a;
                bool kt = int.TryParse(Console.ReadLine(), out a);
                if(kt == false)
                {
                    throw new Exception("Ban Nhan Khong Dung");
                }
                Console.WriteLine("A la {0}", a);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}

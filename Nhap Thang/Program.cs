using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhap_Thang
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Nhap Thang");
                int thang;
                bool kt = int.TryParse(Console.ReadLine(), out thang);
                if (kt == false)
                { throw new Exception("Ban nhap chua dung dinh dang");
                }
                if (thang <= 0 || thang > 12)
                { throw new Exception("Thang khong hop le"); }
                {
                    Console.WriteLine("thang: {0}", thang);
                    int nam;
                    if (thang == 2)
                    {
                        kt = int.TryParse(Console.ReadLine(), out nam);
                        {
                            throw new Exception("nam khong dung dinh dang");
                        }
                        if (nam % 4 == 0)
                        { Console.WriteLine("29 ngay")}
                        else
                        {
                            Console.WriteLine("28 ngay");
                        }
                    }

                    else

                    {
                        int ngay = 31;
                        if (thang == 4 || thang == 6 || thang == 9 || thang == 11)

                        {
                           int ngay = 30;

                        }
                        Console.WriteLine("So ngay: (0), ngay");
                } 

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

            }
            Console.ReadKey();
          
        }
    }
}

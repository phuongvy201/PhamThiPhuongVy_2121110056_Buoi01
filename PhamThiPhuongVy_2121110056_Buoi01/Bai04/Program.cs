using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, P=0;
            double S=0;
            Console.Write("Nhap canh a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap canh c= ");
            c = Convert.ToInt32(Console.ReadLine());
            if ((a + b > c) && (a + c > b) && (b + c > a)) 
            {
                P = a + b + c;
                S = Math.Sqrt(P * (P - a) * (P - b) * (P - c));
                Console.WriteLine("Chu vi hinh tam giac = " + P);
                Console.WriteLine("Dien tich hinh tam giac = " + S);
            }
            else
            {
                Console.WriteLine("Khong phai hinh tam giac!");

            }
            
            Console.ReadKey();
        }
    }
}

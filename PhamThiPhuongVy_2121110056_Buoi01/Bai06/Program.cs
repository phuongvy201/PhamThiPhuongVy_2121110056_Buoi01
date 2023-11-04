using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            double delta = 0, x1, x2;
            int a, b, c;
            Console.Write("Nhap a= ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap b= ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhap c= ");
            c = Convert.ToInt32(Console.ReadLine());
            delta = b * b - 4 * a * c;
            if (delta < 0)
            {
                Console.WriteLine("Phuong trinh vo nghiem");
            }
            else if (delta > 0)
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem kep x1= {0}, x2= {1}", x1, x2);
            }
            else // delta == 0
            {
                x1 = x2 = -b / (2 * a);
                Console.WriteLine("Phuong trinh co 2 nghiem phan biet x1= x2= {0}", x1);
            }
            Console.ReadKey();
        }
    }
}

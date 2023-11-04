using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            int n,s=0;
           Console.Write("Nhap so n: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=2*n-1;i++)
            {
                if(i%2!=0)
                {
                    s += i;
                }
            }
            Console.WriteLine("Tong cac so le = " + s);
            Console.ReadKey();
        }
    }
}

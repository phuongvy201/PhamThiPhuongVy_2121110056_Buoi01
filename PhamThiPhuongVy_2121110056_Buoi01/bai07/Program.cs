using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai07
{
    class Program
    {
        public static bool KTNT(int x)
        {
            if (x < 2) return false;
            for (int i = 2; i * i <= x; i++)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            int n;
            string snt = ""; // Khởi tạo chuỗi snt rỗng

            Console.Write("Nhap so nguyen duong n= ");
            n = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (KTNT(i) == true)
                {
                    snt += i + " ";
                }
            }

            Console.WriteLine("So nguyen to tu 1 den {0}: {1}", n, snt);
            Console.ReadKey();
        }
    }
}

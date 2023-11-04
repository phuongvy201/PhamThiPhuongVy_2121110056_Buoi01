using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cau05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            string[] dssinhvien = new string[n];

            NhapSV(dssinhvien, n);
            XuatSV(dssinhvien, n);

            Console.ReadKey();
         }

        static void NhapSV(string[] dssinhvien, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Nhap ho ten sinh vien thu {0}: ",i+1);
                dssinhvien[i] = Console.ReadLine();
            }
        }

        static void XuatSV(string[] dssinhvien, int n)
        {
            Console.WriteLine("Danh sach sinh vien:");

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Sinh vien thu {0}: {1}", i + 1, dssinhvien[i]);
            }
        }
    }
}

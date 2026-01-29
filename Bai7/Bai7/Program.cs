using System;

namespace Bai7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doan Ngoc Tuong-2415053122348");
            Console.Write("Nhap ho ten: ");
            string chuoi = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(chuoi))
            {
                Console.WriteLine("Chuoi null hoac rong, khong the tach!");
                return;
            }

            string[] a = chuoi.Split(' ');

            if (a == null || a.Length == 0)
                Console.WriteLine("Mang rong!");
            else
            {
                Console.WriteLine("Cac tu trong chuoi:");
                foreach (string tu in a)
                    Console.WriteLine(tu);
            }
        }
    }
}

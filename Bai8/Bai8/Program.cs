using System;

namespace Bai8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doan Ngoc Tuong-2415053122348");
            Console.Write("Nhap chuoi: ");
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
                string longmax = a[0];
                for (int i = 1; i < a.Length; i++)
                {
                    if (a[i].Length > longmax.Length)
                        longmax = a[i];
                }
                Console.WriteLine("tu dai nhat trong chuoi la: " + longmax);
            }
        }
    }
}

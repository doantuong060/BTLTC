using System;

namespace Bai9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doan Ngoc Tuong-2415053122348");
            int n;
            Console.Write("Nhap so phan tu mang: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.Write("Nhap sai, nhap lai: ");
            }

            string[] a = null;
            if (n > 0)
            {
                a = new string[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"nhap a[{i}]: ");
                    a[i] = Console.ReadLine();
                }
            }

            if (a == null || a.Length == 0)
            {
                Console.WriteLine("Mang rong");
            }
            else
            {

                int dem = 0;
                for (int i = 0; i < n; i++)
                    if (!string.IsNullOrWhiteSpace(a[i]))
                        dem++;
                Console.WriteLine($"So chuoi khac rong va null la: {dem}");
            }
        }  
    }
}

using System;

namespace Bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Doan Ngoc Tuong-2415053122348");
            int n;
            Console.Write("Nhap so phan tu mang: ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
                Console.Write("Nhap sai, nhap lai: ");

            int[] a = null;
            if (n > 0)
            {
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"nhap a[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out a[i]))
                        Console.Write($"Nhap sai, nhap lai a[{i}]: ");
                }
            }

            int dem = 0;
            if (a == null)
                Console.WriteLine($"So phan tu chan trong mang la {dem}");
            else
            {
                for (int i = 0; i < n; i++)
                    if (a[i] % 2 == 0)
                        dem++;
                Console.WriteLine($"So phan tu chan trong mang la {dem}");
            }
        }
    }
}

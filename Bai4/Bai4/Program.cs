using System;

namespace Bai4
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

            int[] a = null;
            if (n > 0)
            {
                a = new int[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"nhap a[{i}]: ");
                    while (!int.TryParse(Console.ReadLine(), out a[i]))
                    {
                        Console.Write($"Nhap sai, nhap lai a[{i}]: ");
                    }
                }
            }

            if (a == null)
            {
                Console.WriteLine("Mang chua duoc khoi tao!");
            }
            else
            {
                int tong = 0;
                for (int j = 0; j < n; j++)
                {
                    tong += a[j];
                }
                Console.WriteLine("Tong cac so nguyen trong mang la: " + tong);
            }
        }
    }
}

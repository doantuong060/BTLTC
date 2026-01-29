using System;

namespace Bai5
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

            float[] a = null;
            if (n > 0)
            {
                a = new float[n];
                for (int i = 0; i < n; i++)
                {
                    Console.Write($"nhap a[{i}]: ");
                    while (!float.TryParse(Console.ReadLine(), out a[i]))
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
                float max = a[0];
                for (int i = 1; i < n; i++)
                {
                    if (a[i] > max)
                    {
                        max = a[i];
                    }
                }
                Console.WriteLine($"Gia tri lon nhat trong mang la: {max}");
            }
        }
    }
}

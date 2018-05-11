using System;

namespace Rextester
{
    using ConsoleApp20;

    public class Program
    {
        public static void Main(string[] args)
        {

            int n;
            Console.WriteLine("Введите размер массива ");
            n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            double m;
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write("a[" + Convert.ToString(i + 1) + "]=");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            Delete del = new Delete();
            int[] newArr = del.DeletingFromArray(a, n);
                

            for (int i = 0; i < newArr.Length; i++)
                if (newArr[i] != 0)
                    Console.Write(newArr[i]);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
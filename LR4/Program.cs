using System;

namespace Numb
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Изначальный : ");
            int number = 15;
            int[] array = new int[number];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 10);
                Console.Write(array[i] + " ");
            }
            Rearanger Transfor = new  Rearanger();
            int[] result = Transfor.Rearange(array);
            Console.WriteLine();
            Console.WriteLine("Pезультат:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

            Console.ReadKey();
        }
    }
}

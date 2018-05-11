using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите раз");
            Reiteration art1 = new Reiteration();
         
            int input = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[input];
            Random ran = new Random();
            for (int i = 0; i < input; i++)
            {
                array[i] = ran.Next(-10, 10);
                Console.Write("{0} ", array[i]);

            }
            int result = art1.a(array);
            Console.WriteLine();
            Console.WriteLine(result);
            Console.ReadLine();

        }
    }
}
using System;

namespace ProjectTwo
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("12345");
            string input = Console.ReadLine();
            Number numb = new Number();
            int st = numb.Method(input);
            Console.WriteLine("Результат: {0}", st);
            Console.ReadKey();
        }
    }
}



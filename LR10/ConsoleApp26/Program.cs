using System;
using System.Collections.Generic;
using System.IO;


namespace Lr10
{
    class Program
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\input.txt");
            string input = sr.ReadLine();
            Number numb = new Number();
            int st = numb.Method(input);
            Console.WriteLine("Результат: {0}", st);
            StreamWriter sw = new StreamWriter(@"D:\output.txt");
            sw.Write(st);

            sw.Close();
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}

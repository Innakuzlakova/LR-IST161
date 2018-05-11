using System;
using System.Linq;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0; //сюда мы сохраним итоговое число 
            Console.WriteLine("Введите четырёхзначное число:");
            string s = Console.ReadLine();//объявление и считывание. 
            a = Convert.ToInt32(s); //получение числа
            NumberOperator Number = new NumberOperator();
           
            int mult = Number.CalculateMultiplication(a);
           
            int sum = Number.CalculateSum(a);
            Console.WriteLine("Произведение чисел:");
            Console.WriteLine(mult);
            Console.WriteLine("Сумма чисел:");
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}


using System;
using System.Collections.Generic;

namespace lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Исходный вариант: ");
            List<List<int>> array = new List<List<int>>(); //инициализация

            array.Add(new List<int>() { 38, 32, 11, 88 });//добавление новой строки
            array.Add(new List<int>() { -15, 56, -18, 99 });
            array.Add(new List<int>() { -13, -72, 13, 62 });
            array.Add(new List<int>() { -13, -52, 13, 62});

            for (int a = 0; a < array.Count; a++)
            {
                for (int b = 0; b < array[a].Count; b++)
                {
                    Console.Write(array[a][b] + " ");
                }
                Console.WriteLine();
            }
            AddToAnArray stroke = new AddToAnArray();
            List<List<int>> result = stroke.Delete(array);
            Console.WriteLine("Результат:  ");

            for (int a = 0; a < array.Count; a++)
            {
                for (int b = 0; b < array[a].Count; b++)
                {
                    Console.Write(array[a][b] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}



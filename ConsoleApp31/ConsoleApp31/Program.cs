using System;
using System.Collections.Generic;


namespace lr9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] firstArr = new int[4, 4] { { 1, 6, 2, 10 }, { 4, 3, 5, 11 }, { 9, 7, 8, 12 }, { 13, 15, 14, 16 } };

            Change newArray = new Change(firstArr);
            int[,] newMassiv = newArray.MadeNewArray();
            for (int i = 0; i < newMassiv.GetLength(0); i++)
            {
                for (int j = 0; j < newMassiv.GetLength(1); j++)
                {
                    Console.Write(newMassiv[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}


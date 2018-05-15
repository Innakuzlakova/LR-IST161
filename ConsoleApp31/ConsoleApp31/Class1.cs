using System;

namespace lr9
{
    class Change
    {
        private int[,] arr;
        private int[] newArray = new int[16];
        public Change(int[,] firstArr)
        {
            arr = firstArr;
        }

        private int[] FormatinArr()
        {
            int k = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    newArray[k] = arr[i, j];
                    k++;
                }
            }
            Array.Sort(newArray);
            return newArray;
        }

        //МЕНЯТЬ ЗДЕСЬ
        public int[,] MadeNewArray()
        {
            FormatinArr();
            int z = 0;
            for (int i = 0; i < arr.GetLength(1); i++)

            {
                for (int j = arr.GetLength(0) - 1; j >= 0; --j)
                {
                    //Console.Write(arr [j,i] + " ");
                    arr[i, j] = newArray[z];
                    z++;

                }

            }

            return arr;
        }

    }
}


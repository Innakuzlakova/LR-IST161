using System.Collections.Generic;

namespace lab8
{
    class AddToAnArray
    {
        private int Findelem(List<List<int>> array)
        {
            int indexNumber = 0;
            int minNumber = array[0][0];
            for (int a = 0; a < array.Count; a++)
            {
                for (int b = 0; b < array[a].Count; b++)
                {
                    if (array[a][b] < minNumber)
                    {
                        minNumber = array[a][b];
                        indexNumber = b;
                    }
                }
            }
            return indexNumber;
        }

        public List<List<int>> Delete(List<List<int>> array)
        {
            int minIndex = Findelem(array);
            for (int a = 0; a < array.Count; a++)
            {
                array[a].RemoveAt(minIndex);
            }

            return array;
        }
    }
}

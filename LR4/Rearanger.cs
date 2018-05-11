namespace Numb
{
    class Rearanger
    {
        public int[] Rearange(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                int variable = array[2];
                array[2] = array[4];
                array[4] = variable;
            }

            return array;
        }
    }
}

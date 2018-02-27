using System.Linq;

namespace ConsoleApp4
{
    public class NumberOperator
    {
         public int CalculateMultiplication(int number)
        {
            int[] digits = ExtractDigits(number);
            return digits.Aggregate((d, result) => d * result);
        }
        public int CalculateSum(int number)
        {
            int[] digits = ExtractDigits(number);
            return digits.Sum();
        }
        private int[] ExtractDigits(int number)
        {
            int[] result = new int[4];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = number % 10;
                number /= 10;
            }

            return result;
        }
    }
}

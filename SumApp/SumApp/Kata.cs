using System.Data.Common;

namespace SumApp
{
    public class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            if (numbers.Length > 2)
            {
                var a = numbers[0] < numbers[1] ? numbers[0] : numbers[1];
                var b = numbers[1] < numbers[2] ? numbers[1] : numbers[2];
                return a + b;
            }
            
            return numbers.Length == 0 ? 0 : numbers[0] + numbers[1];
        } 
    }
}
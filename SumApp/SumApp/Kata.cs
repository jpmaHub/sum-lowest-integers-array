using System.Data.Common;
using System;

namespace SumApp
{
    public class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            try
            {
                Array.Sort(numbers);
                return numbers[0] + numbers[1];
            }
            catch (IndexOutOfRangeException)
            {
                return 0;
            } 
        } 
    }
}
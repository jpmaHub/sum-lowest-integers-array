using System;
using SumApp;
using NUnit.Framework;
using System;
using System.Collections.Generic;


namespace sumTest
{
    public class UnitTest1
    {
        [Test]
        public void TestEmptyArrayreturnZero()
        {
            int[] numbers = {};
            Assert.AreEqual(0, Kata.sumTwoSmallestNumbers(numbers));		
        }
        
        [Test]
        public void TestReturnsTwo()
        {
            int[] numbers = {1,1};
            Assert.AreEqual(2, Kata.sumTwoSmallestNumbers(numbers));		
        }
        
        [Test]
        public void TestReturnsSumOfTwo()
        {
            int[] numbers = {1,2};
            Assert.AreEqual(3, Kata.sumTwoSmallestNumbers(numbers));	
        }

        [Test]
        public void TestReturnsSumOfTwoWhenGivenThreeNumbers()
        {
            int[] numbers = {1,3,2};
            Assert.AreEqual(3, Kata.sumTwoSmallestNumbers(numbers));	
        }
        
        [Test]
        public void TestReturnsSumOfTwoWhenGivenFourNumbers()
        {
            int[] numbers = {1,3,2,1};
            Assert.AreEqual(2, Kata.sumTwoSmallestNumbers(numbers));	
        }
        
    }
}
using System;
using System.IO;
using Xunit;
//modified new added
namespace UnitTestProject
{
    public class UnitTest1
    {
        private const string Expected = "Hello World! from Thetips4you";
        [Fact]
        public void Test1()
        {
            int value = 1;
            var result = IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        [Fact]
        public void Test2()
        {
            int value = 1;
            var result = IsPrime(value);

            Assert.False(result, $"{value} should not be prime");
        }
        public bool IsPrime(int candidate)
        {
            if (candidate < 2)
            {
                return false;
            }
            throw new NotImplementedException("Not fully implemented.");
        }
    }
}

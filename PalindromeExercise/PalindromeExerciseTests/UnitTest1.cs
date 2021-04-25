using System;
using Xunit;
using PalindromeExercise;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("hannah", true)]
        public void MyTest(string value, bool expected)
        {
            //arrange

            var test = new WordSmith();

            //act

            bool actual = test.IsAPalindrome(value);

            //assert

            Assert.Equal(expected, actual);
        }
    }
}

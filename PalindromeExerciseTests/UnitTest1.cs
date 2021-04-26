using System;
using PalindromeExercise;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("Racecar", true)]
        [InlineData("hello", false)]
        [InlineData("tacocat", true)]
        [InlineData("foobar", false)]
        [InlineData("truecoders", false)]
        public void MyTest1(string word, bool expected)
        {
            //Arrange
            var wordSmith = new WordSmith();
            //Act
            var actual = wordSmith.IsAPalindrome(word);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}

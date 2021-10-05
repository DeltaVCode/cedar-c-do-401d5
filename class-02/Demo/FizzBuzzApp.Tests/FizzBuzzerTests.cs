using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FizzBuzzApp.Tests
{
    public class FizzBuzzerTests
    {
        [Fact]
        public void FizzBuzz_returns_1_given_1()
        {
            // Arrange
            FizzBuzzer fb = new FizzBuzzer();

            // Act
            string result = fb.FizzBuzz(1);

            // Assert
            Assert.Equal("1", result);
        }

        [Fact]
        public void FizzBuzz_returns_2_given_2()
        {
            // Arrange
            FizzBuzzer fb = new FizzBuzzer();

            // Act
            string result = fb.FizzBuzz(2);

            // Assert
            Assert.Equal("2", result);
        }

        [Fact]
        public void FizzBuzz_returns_Fizz_given_3()
        {
            // Arrange
            FizzBuzzer fb = new FizzBuzzer();

            // Act
            string result = fb.FizzBuzz(3);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Fact]
        public void FizzBuzz_returns_Fizz_given_6()
        {
            // Arrange
            FizzBuzzer fb = new FizzBuzzer();

            // Act
            string result = fb.FizzBuzz(6);

            // Assert
            Assert.Equal("Fizz", result);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void FizzBuzz_returns_Buzz_for_multiples_of_five(int number)
        {
            // Arrange
            FizzBuzzer fb = new FizzBuzzer();

            // Act
            string result = fb.FizzBuzz(number);

            // Assert
            Assert.Equal("Buzz", result);
        }

        [Theory]
        [InlineData(0)]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        [InlineData(600)]
        public void FizzBuzz_returns_FizzBuzz_for_multiples_of_three_and_five(int number)
        {
            // Arrange
            FizzBuzzer fb = new FizzBuzzer();

            // Act
            string result = fb.FizzBuzz(number);

            // Assert
            Assert.Equal("FizzBuzz", result);
        }

        [Fact]
        public void FizzBuzz_throws_for_negative_number()
        {
            // Arrange
            FizzBuzzer fb = new FizzBuzzer();

            // Assert
            // JS arrow function = lambda expression in C#
            Assert.Throws<ArgumentOutOfRangeException>(() =>
            {

                // Act
                string result = fb.FizzBuzz(-1);

            });
        }
    }
}

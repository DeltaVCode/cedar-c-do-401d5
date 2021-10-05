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
    }
}

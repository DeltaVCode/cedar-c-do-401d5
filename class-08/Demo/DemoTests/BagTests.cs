using Demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace DemoTests
{
    public class BagTests
    {
        [Fact]
        public void Bag_starts_empty()
        {
            // Arrange
            Bag<bool> bag = new Bag<bool>();

            // Act
            /* nothing to do */

            // Assert
            Assert.Empty(bag);
            Assert.Equal(0, bag.Count);
        }

        [Fact]
        public void Add_works()
        {
            // Arrange
            Bag<int> bag = new Bag<int>();

            // Act
            bag.Add(1);

            // Assert
            Assert.NotEmpty(bag);
            Assert.Equal(
                new[] { 1 },
                bag);
            Assert.Equal(1, bag.Count);

            // Act
            bag.Add(2);

            // Assert
            Assert.Equal(
                new[] { 1, 2 },
                bag);
            Assert.Equal(2, bag.Count);

            // Act
            bag.Add(3);

            // Assert
            Assert.Equal(
                new[] { 1, 2, 3 },
                bag);
            Assert.Equal(3, bag.Count);
        }

    }
}

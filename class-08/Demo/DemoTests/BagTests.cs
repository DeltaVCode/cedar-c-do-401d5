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
        }

        [Fact]
        public void Add_works()
        {
            // Arrange
            Bag<int> bag = new Bag<int>();

            // Act
            bag.Add(1);

            // Assert
            Assert.Equal(
                new[] { 1 },
                bag);
        }

    }
}

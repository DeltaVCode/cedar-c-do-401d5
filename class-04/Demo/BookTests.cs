using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Demo
{
    public class BookTests
    {
        [Fact]
        public void Book_constructor_requires_title()
        {
            // Arrange


            // Act
            Book book = new Book("Lord of the Fries");

            // Assert
            Assert.Equal("Lord of the Fries", book.Title);

            Assert.Equal("Lord of the Fries", book.GetTitle());
        }
    }
}

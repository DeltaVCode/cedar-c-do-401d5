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

        [Fact]
        public void Can_get_set_PageCount()
        {
            // Arrange
            Book book = new Book("Test");

            // Act/Assert
            Assert.Equal(0, book.PageCount);

            book.PageCount = 20;

            Assert.Equal(20, book.PageCount);
        }

        [Fact]
        public void Can_set_Author()
        {
            Book bookWithAuthor = new Book("Test");

            bookWithAuthor.Author = new Author()
            {
                // Object Initializer can set property values
                FirstName = "Bob",
                LastName = "Barker",
            };

            Assert.Equal("Bob", bookWithAuthor.Author.FirstName);
        }
    }
}

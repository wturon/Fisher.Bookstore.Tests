using System;
using Fisher.Bookstore.Models;
using Xunit;

namespace Fisher.Bookstore.Tests
{
    public class BookTests
    {
        [Fact]
        public void AddBookPrice()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                Price = 9.99
            };

            //Act
            book.Price = 7.99;

            //Assert
            Assert.Equal(7.99, book.Price);

        }

        [Fact]
        public void TestMemberDiscount()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1,
                Title = "My Test Book",
                Price = 9.99
            };

            //Act
            book.ApplyMemberDiscount();

            //Assert
            var discountPrice = 9.99 * .9;
            Assert.Equal(discountPrice, book.Price);
        }
    }
}

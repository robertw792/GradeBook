using System;
using Xunit;
using GradeBook;
namespace GradeBook.Tests
{
    public class BookTests
    {
       [Fact]
        public void Test1()
        {
            // arrange
            var book = new Book("");
            book.AddGrade(82.2);
            book.AddGrade(90.4);
            book.AddGrade(23);

            // act
            var stats = book.GetStatistics();

            // assert
            Assert.Equal(65.2, stats.Average);
            Assert.Equal(90.4, stats.High);
            Assert.Equal(23, stats.Low);
        }
    }
}

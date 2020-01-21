using Xunit;
namespace GradeBook.Tests
{
    public class BookTest
    {
       [Fact]
        public void BookCalculatesAnAverageGrade()
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

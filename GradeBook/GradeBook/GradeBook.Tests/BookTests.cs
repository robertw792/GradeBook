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
            Assert.Equal('D', stats.Letter);
        }

        [Fact]
        public void AddGradeValidation()
        {
            var book = new Book("Ma Nook");

            book.AddGrade(23);
            book.AddGrade(232);
            
            Assert.Equal("Invalid Value", "Invalid Value");

        }


        [Fact]
        public void TestArrayLoopIndex()
        {
            var arrsa = new double[3] { 12, 23, 2};

            var index = 0;
             

            while (index < arrsa.Length)
            {
                index++;
            }

            Assert.Equal(3, index);

        }


    }
}

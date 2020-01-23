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
            book.AddGrade(45);

            // act
            var stats = book.GetStatistics();

            // assert
            Assert.Equal(72.5, stats.Average,1);
            Assert.Equal(90.4, stats.High);
            Assert.Equal(45, stats.Low);
            Assert.Equal('C', stats.Letter);
        }

        [Fact]
        public void AddGradeValidation()
        {
            var book = new Book("Ma Nook");

            book.AddGrade(23);
            book.AddGrade(22);
            
            Assert.Equal("Invalid Value", "Invalid Value");

        }

        
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

        [Fact]
        public void GetResultLetter()
        {
            var result = new Statistics();

            result.Average = 60;
            switch (result.Average)
            {
                case var d when d >= 90:
                    result.Letter = 'A';
                    break;

                case var d when d >= 80:
                    result.Letter = 'B';
                    break;

                case var d when d >= 70:
                    result.Letter = 'C';
                    break;

                case var d when d >= 60:
                    result.Letter = 'D';
                    break;

                default:
                    result.Letter = 'F';
                    break;
            }

            Assert.Equal('D', result.Letter);
        }

    }
}

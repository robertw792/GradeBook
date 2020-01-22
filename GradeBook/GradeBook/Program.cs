using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Robert's Grade Book");
            var index = 0;
            while(index < 3)
            {
                Console.WriteLine("Please enter a grade or 'q' to quit");
                var input = Console.ReadLine();

                if (input == "q")
                {
                    break;
                }

                try
                {

                var grade = double.Parse(input);
                book.AddGrade(grade);

                }
                catch(ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine(ex.Message);
                }
               finally
                {
                    Console.WriteLine("Write it");
                }

                index += 1;
            }
            var stats = book.GetStatistics();

            Console.WriteLine($"The highest grade of {book.Name} is {stats.High}");
            Console.WriteLine($"The lowest grade of {book.Name} is {stats.Low}");
            Console.WriteLine($"The average grade of {book.Name} is {stats.Average:N1}");

            Console.ReadKey();
        }
    }
}

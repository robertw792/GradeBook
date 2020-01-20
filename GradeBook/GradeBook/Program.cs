using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Robert's Grade Book");

            book.AddGrade(23);
            book.AddGrade(32);
            book.AddGrade(3);

            book.CalculateStatistics();

        }
    }
}

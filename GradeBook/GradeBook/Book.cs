using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            this.name = name;

        }

        private List<double> grades = new List<double>();
        private string name;

        public void AddGrade(double grade)
        {
            grades.Add(grade);
        }

        public void CalculateStatistics()
        {
            var results = 0.0;

            var highGrade = double.MinValue;
            var lowGrade = double.MaxValue;

            foreach (var number in grades)
            {
                highGrade = Math.Max(number, highGrade);
                lowGrade = Math.Min(number, lowGrade);

                results += number;
            }

            results /= grades.Count;

            Console.WriteLine($"Average grade is {results:N1}");
            Console.WriteLine($"Highest grade is {highGrade:N1}");
            Console.WriteLine($"Lowest grade is {lowGrade:N1}");
            Console.ReadKey();
        }

    }
}
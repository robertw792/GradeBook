using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {         
            var numbers = new [] { 12.7, 10.3, 6.11 };

            List<double> grades = new List<double>() { 12.3, 12, 14.3 };
            grades.Add(12);
          
            var results = 0.0;

            foreach(var number in grades)
            {
                results += number;
            }

            results /= grades.Count;

            Console.WriteLine($"Average grade is {results:N1}");
            Console.ReadKey();

            if (args.Length > 0)
            {
                Console.WriteLine($"Hello, {args[0]}!");
                Console.ReadKey();
            }

            else
            {

            }


        }
    }
}

using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double x;
            double y;
            double sum;

            x = 34.12;
            y = 23.21;

            sum = x + y;

            if (args.Length > 0)
            {
                Console.WriteLine($"Hey, {args[0]}!");
                Console.ReadKey();
            }

            else
            {
                Console.WriteLine(sum);
                Console.ReadKey();
            }


        }
    }
}

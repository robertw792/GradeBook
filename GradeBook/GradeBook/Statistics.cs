using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook
{
    public class Statistics
    {
        public double Average
        {
            get
            {
                return Sum / Count;
            }
        }
        
        public double High;
        public double Low;
        public double Sum;
        public int Count;

        public Statistics()
        {
            Count = 0;
            Sum = 0.0;
            High = double.MinValue;
            Low = double.MaxValue;
        }


        public void Add(double number)
        {
            Sum += number;
            Count++;
            Low = Math.Min(number, Low);
            High = Math.Max(number, High);
        }



        public char Letter
        {
            get
            {
                switch (Average)
                {
                    case var d when d >= 90:
                        return 'A';

                    case var d when d >= 80:
                        return 'B';

                    case var d when d >= 70:
                        return 'C';

                    case var d when d >= 60:
                        return 'D';

                    default:
                        return 'F';
                }

            }

        }
    }
}

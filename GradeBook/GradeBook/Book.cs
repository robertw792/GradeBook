﻿using System;
using System.Collections.Generic;

namespace GradeBook
{
    public delegate void GradeAddedDelegate(object sender, EventArgs args);



    public class Book
    {
        public Book(string name)
        {
            grades = new List<double>();
            Name = name;

        }       

        private List<double> grades = new List<double>();
        private string name;
        public readonly string Category = "Science";
        public string Name
        {
            get;
            set;
        }
        

        
        public void AddGrade(char letter)
        {
            switch(letter)
            {
                case 'A':
                    AddGrade(90);
                    break;

                case 'B':
                    AddGrade(80);
                    break;

                case 'C':
                    AddGrade(70);
                    break;

                case 'D':
                    AddGrade(60);
                    break;

                default:
                    AddGrade(0);
                    break;
            }
        }


        public event GradeAddedDelegate GradeAdded;

        public void AddGrade(double grade)
        {
            if(grade <= 100 && grade >= 0)
            { 
                grades.Add(grade);

                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }

            else
            {
                throw new ArgumentException($"Invalid {nameof(grade)}");
            }

        }

        public Statistics GetStatistics()
        {
            var result = new Statistics();

            result.Average = 0.0;
            result.High = double.MinValue;
            result.Low = double.MaxValue;

            for (var index = 0; index < grades.Count; index += 1)
            {
                result.Low = Math.Min(grades[index], result.Low);
                result.High = Math.Max(grades[index], result.High);
                result.Average += grades[index];
            }

            result.Average /= grades.Count;
            
            result.Letter = GetResultLetter(result.Average);

            return result;

        }

        public char GetResultLetter(double grade)
        {
            var result = new Statistics();

            switch (grade)
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

            return result.Letter;
        }
    }
}
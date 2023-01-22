/*
 Author: Dequandre Span
 Date: 1/22/2023
 Description: C# Console Application for calculating letter grades
*/

using System; 

namespace Deliverable__2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {
                decimal grade = decimal.Parse(Console.ReadLine());

                string letter;

                if (grade >= 90)
                {
                    letter = "A";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is A");
                }

                if (grade >= 80)
                {
                    letter = "B";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is B");
                }

                if (grade >= 70)
                {
                    letter = "C";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is C");
                }

                if (grade >= 60)
                {
                    letter = "D";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is D");
                }

                if (grade <= 59)
                {
                    letter = "F";
                    Console.WriteLine("Your expected letter grade for ISM 4300 is F");
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }
        }
    }
}
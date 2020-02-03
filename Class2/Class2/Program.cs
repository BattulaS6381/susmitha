using System;

namespace grade
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 0;
            int grade = 0;
            int counter = 0;
            int A = 0;
            int B = 0;
            int C = 0;
            int F = 0;

            while (grade >= 0)
            {
                Console.WriteLine("Enter grade of student:");
                grade = Convert.ToInt32(Console.ReadLine());
                if (grade >= 90)
                {
                    A = A + 1;
                }
                else if (grade >= 80)
                {
                    B = B + 1;

                }
                else if (grade >= 70)
                {
                    C = C + 1;

                }
                else if (grade < 60 && grade >= 0)
                {
                    F = F + 1;

                }
                total += grade;
                counter++;

            }

            double average = (double)total / counter;
            Console.WriteLine("The class average is: " + average);

            Console.WriteLine($"Number of students who earned grade A are {A}");
            Console.WriteLine($"Number of students who earned grade B are {B}");
            Console.WriteLine($"Number of students who earned grade C are {C}");
            Console.WriteLine($"Number of students who earned grade F are {F}");

            int count = 0;
            Console.Write("Grade A:");
            while (count < A)
            {
                Console.Write("*");
                count++;
            }
            Console.Write($"({A})");
            count = 0;

            Console.Write("\nGrade B:");
            while (count < B)
            {
                Console.Write("*");
                count++;
            }
            Console.Write($"({B})");
            count = 0;
            Console.Write("\nGrade C:");
            while (count < C)
            {
                Console.Write("*");
                count++;
            }
            Console.Write($"({C})");
            count = 0;
            Console.Write("\nGrade F:");
            while (count < F)
            {
                Console.Write("*");
                count++;
            }
            Console.WriteLine($"({ F})");




        }
    }
}
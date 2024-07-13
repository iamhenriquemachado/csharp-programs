using System;

namespace student_grade
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 01: Request the number of students
            Console.WriteLine("Please, insert the number of students: ");
            int studentsQuantity = int.Parse(Console.ReadLine());

            // Step 02: Create an array to save students grades
            double[] grades = new double[studentsQuantity];

            // Step 03: Create an loop to insert students grades
            for (int i = 0; i < studentsQuantity; i++)
            {
                Console.WriteLine($"Insert grades {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());   
            }

            //Step 04: Calculate average grades
            double sum = 0;
            for (int i = 0; i < studentsQuantity; i++)
            {
                sum += grades[i];
            }
            double average = sum / studentsQuantity;

            //Step 05: Max and min grades
            double maxGrade = grades[0];
            double minGrade = grades[0];

            for (int i = 1; i < studentsQuantity; i++)
            {
                if (grades[i] > maxGrade)
                {
                    maxGrade = grades[i];   
                }
                if (grades[i] < minGrade)
                {
                    minGrade = grades[i];
                }
            }

            // Step 06: Print results
            Console.WriteLine($"Max grade is: {maxGrade}");
            Console.WriteLine($"Min grade is: {minGrade}");
            Console.WriteLine($"Average grade is: {average}");
        }

    }
}

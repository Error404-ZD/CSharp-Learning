using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharp.Mod_10___Arrays
{
    public class ArraysPractice
    {

        public static void SingleDimensionArray()
        {
            string[] studentNames = { "Anirudh", "Aditya", "Lokesh", "Praneetha", "Dhanush" };

            for (int i = 0; i <= studentNames.Length - 1; i++)
            {
                Console.WriteLine($"Student - {i+1} : {studentNames[i]}");
            }

            foreach (string studentName in studentNames)
            {
                Console.WriteLine($"Student : {studentName}"); 
            }
        }

        public static void MarksAnalysis()
        {
            double[] fiveStudentMarks = { 98.6, 89, 63.6, 76, 87.8 };
            double highestMark = fiveStudentMarks[0];
            double lowestMark = fiveStudentMarks[0];
            double sum = 0;
            for (int i = 0; i <= fiveStudentMarks.Length - 1; i++)
            {
                double currentMark = fiveStudentMarks[i];

                if (currentMark > highestMark)
                {
                    highestMark = currentMark;
                }
                if (currentMark < lowestMark)
                {
                    lowestMark = currentMark;
                }

                sum = sum + currentMark;
            }
            double average = sum / fiveStudentMarks.Length;
            Console.WriteLine($"Highest : {highestMark}");
            Console.WriteLine($"Lowest  : {lowestMark}");
            Console.WriteLine($"Average : {average}");
        }

        public static void ArrayUpdate()
        {
            int[] marks = { 1, 3, 3, 4, 5, 6 };
            marks[1] = 2;
            for (int i = 0; i <= marks.Length - 1; i++)
            {
                Console.WriteLine(marks[i]);
            }
            Console.WriteLine();
            foreach (int mark in marks)
            {
                Console.WriteLine(mark);
            }
        }

        public static void MultiDimensionalArray()
        {
            char[,] alphabets =
            {
                { 'L', 'O', 'K' },
                { 'E', 'S', 'H' },
                { 'Y', 'E', 'S' },
            };
            for (int i = 0; i <= 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(alphabets[i, j]);
                }
            }Console.WriteLine();
            
        }

        public static void JaggedArray()
        {
            int[][] marks =
            {
                new int[] {63, 78},
                new int[] {98, 89, 94, 100},
                new int[] {89, 75, 64}
            };
            foreach (int[] studentMarks in marks)
            {
                foreach (int mark in studentMarks)
                {
                    Console.WriteLine(mark);
                }
            }
        }

    }
}

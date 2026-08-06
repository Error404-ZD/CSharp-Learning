using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Mod_8___Loops
{
    public class LoopsPractice
    {

        public static void DisplayWhileLoop()
        {
            int i = 1;
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;
            }
        }

        public static void DisplayDoWhileLoop()
        {
            int number;
            do
            {
                Console.Write("Enter a Number: ");
                string? input = Console.ReadLine();
                if (int.TryParse(input?.Trim(), out  number))
                {
                    Console.WriteLine($"Entered Number : {number}");
                }
                else
                {
                    Console.WriteLine("Invalid Input. Please enter a valid number Ex: 25 ");
                    number = -1; //force another iteration - can be -1, +1 any value except 0
                }
            } while (number != 0);
        }

        public static void DisplayForLoop()
        {

            for (int a = 10; a >= 1; a --) 
            {
                Console.WriteLine( a );
            }
        }

        public static void DisplayMultiplicationTable()
        {
            Console.Write("Enter a Number : ");
            string? input = Console.ReadLine();
            bool success = int.TryParse(input?.Trim(), out int number);
            if(success)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine($"{number} * {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
        }

        public static void Displaybreak()
        {
            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i);

                if (i == 13)
                {
                    break;
                }
            }
        }

        public static void DisplayContinue()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void DisplayNestedLoops()
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int k = 1; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int row = 1; row <= 5; row++)
            {

                for (int j = 5; j >= row; j--)
                {
                    Console.Write($"*");
                }
                Console.WriteLine();
            }


            for (int r = 1; r <= 5; r++)
            {
                for (int space = 4; space >= r; space--)
                {
                    Console.Write(" ");
                }
                for (int star = 1; star <= r; star++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b < a; b++)
                {
                    Console.Write(" ");
                }
                for (int c = 5; c >= a; c--)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            for (int d = 1; d <= 5; d++)
            {
                for (int e = 4; e >= d; e--)
                {
                    Console.Write(" ");
                }
                for (int f = 1; f <= d * 2 - 1; f++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            for (int g = 1; g <= 5; g++)
            {
                for (int h = 1; h < g; h++)
                {
                    Console.Write(" ");
                }
                for (int l = 9; l >= g * 2 - 1; l--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

    }
}

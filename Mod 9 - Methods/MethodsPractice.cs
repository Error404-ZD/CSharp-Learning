using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Mod_9___Methods
{
    public class MethodsPractice
    {

        public static void DisplayGreeting()
        {
            Console.WriteLine("Welcome to Modern C#");
        }

        public static void DisplayStudent(string name, int age, string city)
        {
            Console.WriteLine($"Name : {name}\nAge  : {age}\nCity : {city}");
        }

        public static double AddNumbers(double a, double b)
        {
            double sum = a + b;
            Console.WriteLine($"Sum of {a} & {b} : {sum}");
            return sum;
        }

        public static double FindSquare()
        {
            while (true)
            {
                Console.Write("Enter a Number : ");
                string? input = Console.ReadLine();

                if (double.TryParse(input, out double output))
                {
                    double square = output * output;
                    return square;
                }

                else
                {
                    Console.WriteLine("Invalid Input\nPlease try again");
                    continue;
                }
            }
        }

        public static void Display(int value)
        {
            Console.WriteLine(value);
        }

        public static void Display(double value)
        {
            Console.WriteLine(value);
        }

        public static void Display(string value)
        {
            Console.WriteLine(value);
        }

        public static void DisplayWelcome(string name = "Guest")
        {
            Console.WriteLine($"Name : {name}");
        }

        public static void DisplayStudentDetails(string name, int age, string city)
        {
            Console.WriteLine($"{name}\n{age}\n{city}");
        }

        public static string GetCountry() => "India";
    }
}

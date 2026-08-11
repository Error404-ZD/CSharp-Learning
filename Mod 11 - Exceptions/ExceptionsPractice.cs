using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Mod_11___ExceptionsHandling
{
    public class ExceptionsPractice
    {
        public static void BasicTryCatch()
        {
            try
            {
                Console.Write($"Enter a Number : ");
                string? inputOne = Console.ReadLine();
                int outputOne = Convert.ToInt32(inputOne);
                Console.Write($"Enter a Number : ");
                string? inputTwo = Console.ReadLine();
                int outputTwo = Convert.ToInt32(inputTwo);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Invalid number entered.");
            }
        }

        public static void TryCatchWithDivision()
        {
            try
            {
                Console.Write($"Input 1 : ");
                string? inputOne = Console.ReadLine();
                int outputOne = Convert.ToInt32(inputOne);
                Console.Write($"Input 2 : ");
                string? inputTwo = Console.ReadLine();
                int outputTwo = Convert.ToInt32(inputTwo);
                double divide = outputOne / outputTwo;
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Invalid number entered.");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex);
                Console.WriteLine("Division by Zero.");
            }
        }

        public static void TryCatchWithExceptionObject()
        {
            try
            {
                Console.Write($"Input 1 : ");
                string? inputOne = Console.ReadLine();
                int outputOne = Convert.ToInt32(inputOne);
                Console.Write($"Input 2 : ");
                string? inputTwo = Console.ReadLine();
                int outputTwo = Convert.ToInt32(inputTwo);
                double divide = outputOne / outputTwo;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
        }

        public static void TryCatchWithFinally()
        {
            try
            {
                Console.Write($"Input 1 : ");
                string? inputOne = Console.ReadLine();
                int outputOne = Convert.ToInt32(inputOne);
                Console.Write($"Input 2 : ");
                string? inputTwo = Console.ReadLine();
                int outputTwo = Convert.ToInt32(inputTwo);
                double divide = (double)outputOne / outputTwo;
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
        }

        public static void TryCatchWithThrow()
        {
            try
            {
                Console.Write("Enter Age : ");
                string? input = Console.ReadLine();
                int output = Convert.ToInt32(input);
                if (output < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
        }

        public static void TryCatchWithMultipleExceptions()
        {
            try
            {
                Console.Write($"Input 1 : ");
                string? inputOne = Console.ReadLine();
                double outputOne = Convert.ToDouble(inputOne);
                Console.Write($"Input 2 : ");
                string? inputTwo = Console.ReadLine();
                double outputTwo = Convert.ToDouble(inputTwo);
                double divide = outputOne / outputTwo;
                double addition = outputOne + outputTwo;
                double subtraction = outputOne - outputTwo;
                double multiplication = outputOne * outputTwo;
                Console.WriteLine($"{outputOne} / {outputTwo} : {divide}");
                Console.WriteLine($"{outputOne} + {outputTwo} : {addition}");
                Console.WriteLine($"{outputOne} - {outputTwo} : {subtraction}");
                Console.WriteLine($"{outputOne} * {outputTwo} : {multiplication}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
        }

        public static void ArrayException()
        {
            try
            {
                int[] numbers = { 10, 20, 30, 40, 50 };
                Console.Write("Enter an Index : ");
                string? input = Console.ReadLine();
                int index = Convert.ToInt32(input);
                Console.WriteLine($"Entered Index {index} : {numbers[index]}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
        }

        public static void MiniProject()
        {
            try
            {
                Console.Write($"Name       : ");
                string name = Console.ReadLine()!;
                Console.Write($"Age        : ");
                string? inputOne = Console.ReadLine();
                int age = Convert.ToInt32(inputOne);
                Console.Write($"Percentage : ");
                string? inputTwo = Console.ReadLine();
                double percentage = Convert.ToDouble(inputTwo);
                if (age < 0)
                {
                    throw new Exception("Age cannot be negative.");
                }
                if (percentage < 0 || percentage > 100)
                {
                    throw new Exception("Percentage must be between 0 and 100.");
                }

            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception Type    : {ex.GetType().Name}");
                Console.WriteLine($"Exception Message : {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Program Completed");
            }
        }
    }

}

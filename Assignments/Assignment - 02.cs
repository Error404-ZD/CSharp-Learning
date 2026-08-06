using System.Numerics;


namespace CSharp.Assignments
{
    public class Assignment_02
    {

        public static void DisplayOneToTwentyNumbers()
        {
            for (int a = 1; a <= 20; a++)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        public static void DisplayReverseCounting()
        {
            for (int a = 20; a >= 1; a--)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();
        }

        public static void DisplayEvenNumbers()
        {
            for (int a = 2; a <= 20; a += 2)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();

            for (int a = 2; a <= 20; a++)
            {
                if (a % 2 == 0)
                {
                    Console.Write($"{a} ");
                }
            }
            Console.WriteLine();
        }

        public static void DisplayOddNumbers()
        {
            for (int a = 1; a <= 20; a += 2)
            {
                Console.Write($"{a} ");
            }
            Console.WriteLine();

            for (int a = 1; a <= 20; a++)
            {
                if (a % 2 != 0)
                {
                    Console.Write($"{a} ");
                }

            }
            Console.WriteLine();
        }

        public static void DisplayMultiplicationTable()
        {
            Console.Write($"Enter Number : ");
            string? input = Console.ReadLine();
            bool success = decimal.TryParse(input!.Trim(), out decimal number);
            if (success)
            {
                for (int a = 1; a <= 10; a++)
                {
                    Console.WriteLine($"{number} * {a} = {number * a}");
                }
            }
        }

        public static void DisplaySumOfOneToHundread()
        {
            int sum = 0;
            for (int a = 1; a <= 100; a++)
            {
                sum += a;
            }
            Console.WriteLine(sum);
        }

        public static void DisplayFactorialValue()
        {

            while (true)
            {
                Console.Write($"Enter a number (or Type 'exit' to quit) : ");
                string? input = Console.ReadLine()!;

                if (input.ToLower() == "exit")
                {
                    break;
                }
                bool success = double.TryParse(input!.Trim(), out double number);
                if (success)
                {
                    if (number < 0)
                    {
                        Console.WriteLine("Error : Cannot calculate negative factorials");
                    }

                    else
                    {
                        BigInteger result = (BigInteger)number;
                        BigInteger final = 1;
                        for (BigInteger a = result; a >= 1; a--)
                        {
                            final = final * a;
                        }
                        Console.WriteLine($"factorial is : {final}");
                    }
                }

                else
                {
                    Console.WriteLine($"Invalid input");
                }
            }
            Console.WriteLine();
            Console.WriteLine($"Hope you Found your Answers! Revert back if you need anything");
            Console.WriteLine();
        }

        public static void DisplayPasswordRetry()
        {
            while (true)
            {
                Console.Write($"Enter Password : ");
                string? input = Console.ReadLine();

                if (input == "CSharp2026")
                {
                    break;
                }
                else
                {
                    Console.WriteLine($"Wrong password \nTry again.");
                }

            }
            Console.WriteLine($"Correct Password");
            Console.WriteLine();

        }

        public static void DisplayGuessTheNumber()
        {
            Random random = new Random();
            int secret = random.Next(1, 101);
            bool isWon = false;

            for (int a = 5; a >= 1; a--)
            {
                Console.Write("Guess the number (1 - 100) : ");
                string? input = Console.ReadLine();
                bool success = BigInteger.TryParse(input?.Trim(), out BigInteger number);
                if (!success)
                {
                    Console.WriteLine("Invalid Input. Try again without loosing a turn ");
                    a++;
                    continue;
                }

                if (number == secret)
                {
                    Console.WriteLine("Correct Number!");
                    isWon = true;
                    break;
                }

                if (number > secret)
                {
                    Console.WriteLine($"\tNumber is Too High!");
                }

                else
                {
                    Console.WriteLine($"\tNumber is Too Low!");
                }

                Console.WriteLine($"\tYou have {a - 1} attempts left.");

                if (a != 1)
                {
                    Console.WriteLine("\tTry again.");
                }
            }
            if (!isWon)
            {
                Console.WriteLine();
                Console.WriteLine($"Guessing limits are over. the number was {secret} \nPlease try again after sometime");
            }
        }

        public static void DisplayStarRectangle()
        {
            string star = "*";

            for (int a = 1; a <= 4; a++)
            {
                for (int b = 1; b <= 5; b++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayHollowRectangle()
        {
            string star = "*";
            string space = " ";
            for (int a = 1; a <= 4; a++)
            {
                for (int b = 1; b <= 5; b++)
                {
                    if (a == 1 || a == 4 || b == 1 || b == 5)
                    {
                        Console.Write(star);
                    }

                    else
                    {
                        Console.Write(space);
                    }
                }
                Console.WriteLine();
            }
        }

        public static void DisplayRightAngleTriangle()
        {
            string star = "*";
            for (int a = 0; a <= 4; a++)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayInvertedTriangle()
        {
            string star = "*";
            for (int a = 4; a >= 0; a--)
            {
                for (int b = 0; b <= a; b++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayPyramid()
        {
            string star = "*";
            string space = " ";
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 4; b >= a; b--)
                {
                    Console.Write(space);
                }
                for (int c = 1; c <= a * 2 - 1; c++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayInvertedPyramid()
        {
            string star = "*";
            string space = " ";
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 2; b <= a; b++)
                {
                    Console.Write(space);
                }
                for (int c = 9; c >= a * 2 - 1; c--)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayDiamond()
        {
            string star = "*";
            string space = " ";
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 4; b >= a; b--)
                {
                    Console.Write(space);
                }
                for (int c = 1; c <= a * 2 - 1; c++)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }
            for (int d = 1; d <= 4; d++)
            {
                for (int e = 1; e <= d; e++)
                {
                    Console.Write(space);
                }
                for (int f = 7; f >= d * 2 - 1; f--)
                {
                    Console.Write(star);
                }
                Console.WriteLine();
            }

        }

        public static void DisplayRightAngledNumberTriangle()
        {
            for (int a = 1; a <= 9; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }

        }

        public static void DisplayNumberPyramid()
        {
            string space = " ";
            for (int a = 1; a <= 5; a++)
            {
                for (int c = 4; c >= a; c--)
                {
                    Console.Write(space);
                }
                for (int b = 1; b <= a * 2 - 1; b++)
                {
                    Console.Write(b);
                }
                Console.WriteLine();
            }
            for (int d = 4; d >= 1; d--)
            {
                for (int e = 4; e >= d; e--)
                {
                    Console.Write(space);
                }
                for (int f = 1; f <= d * 2 - 1; f++)
                {
                    Console.Write(f);
                }
                Console.WriteLine();
            }
        }

        public static void DisplayRepeatedRightTriangle()
        {
            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write(a);
                }
                Console.WriteLine();
            }

            for (int e = 1; e <= 5; e++)
            {
                for (int f = 4; f >= e; f--)
                {
                    Console.Write(" ");
                }
                for (int g = 1; g <= e * 2 - 1; g++)
                {
                    Console.Write(e);
                }
                Console.WriteLine();
            }

            for (int h = 4; h >= 1; h--)
            {
                for (int i = 4; i >= h; i--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= h * 2 - 1; j++)
                {
                    Console.Write(h);
                }
                Console.WriteLine();
            }

        }

        /*public static void DisplayCountDigits()
        {
            string? input;
            string toExit = "exit";
            bool freeTrial = true;
            for(int a = 10; a >= 1; a--)
            {
                Console.Write("Enter Input as number (or type exit to quit) : ");
                input = Console.ReadLine();
                if (input?.ToLower() == toExit)
                {
                    Console.WriteLine($"Sorry to see you go.");
                    String? reason = Console.ReadLine();
                    Console.WriteLine($"Enter your reason to exit : {reason}");
                    Console.WriteLine($"You still have \'{a}\' free trials left");
                    Console.WriteLine($"If you want to exit please type \"quit\" : {Console.ReadLine()} ");
                    break;
                }
                bool success = double.TryParse(input?.Trim(), out double number);
                if (success)
                {
                    int result = number.ToString().Length;
                    Console.WriteLine($"Digit Count : {result} digits");

                    

                }
                else
                {
                    Console.WriteLine("Invalid Input, Please try again.");
                }


            }
            
            if (!freeTrial)
            {
                Console.WriteLine($"your free trial is over!\nPlease subscribe to keep using.");
            }
        }*/

        /* public static void DisplayMenuDrivenCalculator()
         {
             while (true)
             {
                 ⭐ Boss Challenge(No Help Until You Finish)

 Build a menu - driven calculator.

 ======== Calculator ========

 1. Add
 2. Subtract
 3. Multiply
 4. Divide
 5. Exit

 Choose :

 After every calculation, show the menu again.

 Only exit when the user chooses 5.

 You'll use:

 while or do-while
 switch
 if
 TryParse
 Methods you've already learned
 Operators
 Strings
 User input

 This is your first mini console application.
             }
         }*/
    }
}

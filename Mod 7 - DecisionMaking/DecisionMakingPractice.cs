namespace CSharp.Mod_7___DecisionMaking
{
    public class DecisionMakingPractice
    {

        public static void DisplaySimpleIf()
        {
            Console.Write("Enter your Age   : ");
            string? age = Console.ReadLine();
            if (int.TryParse(age, out int result))
            {
                Console.WriteLine($"User Age    : {result}");
                if (result >= 18)
                {
                    Console.WriteLine("Eligible to vote");
                }

            }
            else
            {
                Console.WriteLine("Invalid Input. Enter age in number");
            }

        }

        public static void DisplayIfElse()
        {
            Console.Write("Enter your Marks : ");
            string? marks = Console.ReadLine();
            if (int.TryParse(marks, out int result))
            {
                Console.WriteLine($"User Marks  : {result}");
                if (result >= 35)
                {
                    Console.WriteLine("Pass");
                }

                else
                {
                    Console.WriteLine($"Fail");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Enter marks as number");
            }
           
        }

        public static void DisplayElseIf()
        {

            Console.Write("Enter your Marks : ");
            string? marks = Console.ReadLine();
            if (int.TryParse(marks, out int result))
            {
                Console.WriteLine($"User Marks  : {result}");
                if (result >= 90)
                {
                    Console.WriteLine("Grade A");
                }

                else if (result >= 75)
                {
                    Console.WriteLine($"Grade B");
                }

                else if (result >= 50)
                {
                    Console.WriteLine($"Grade C");
                }

                else
                {
                    Console.WriteLine($"Fail");
                }
            }
            else
            {
                Console.WriteLine("Inavlid Input. Enter Marks as number");
            }
           

        }

        public static void DisplayNestedIf()
        {

            Console.Write("Enter your Age : ");
            string? age = Console.ReadLine();
            if (int.TryParse(age, out int result))
            {
                Console.WriteLine($"User Age  : {result}");

                if (result >= 18)
                {
                    Console.Write("User Has Driving Licence (True/False) : ");
                    string? hasDrivingLicence = Console.ReadLine();
                    if (bool.TryParse(hasDrivingLicence, out bool output))
                    {
                        Console.WriteLine($"User  has driving licence : {output}");
                        if (output)
                        {
                            Console.WriteLine("user can legally drive");
                        }

                        else
                        {
                            Console.WriteLine("user is 18+ but does not have a valid licence");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                    }



                }

                else
                {
                    Console.WriteLine("User is below 18");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. please enter age in number");
            }
            

        }

        public static void DisplaySwitch()
        {
            Console.Write("Enter a number from 1-7 to select weekday : ");
            string? number = Console.ReadLine();
            if (int.TryParse(number, out int result))
            {
                Console.WriteLine($"Entered Number  : {result}");
                switch (result)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Invalid number Entered");
                        break; // replaced continue with break
                }
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        }

        public static void DisplayModernSwitchExpression()
        {

            Console.Write("Enter a grade from A-D to know performance : ");
            string? grade = Console.ReadLine();
            if (char.TryParse(grade?.Trim().ToUpper(), out char output))
            {
                Console.WriteLine($"Entered grade  : {output}");
                string result = output switch
                {
                    'A' => "Excellent",
                    'B' => "Good",
                    'C' => "Average",
                    'D' => "You can do it",
                    _ => "Entered Grade Doesnt exist / Invalid Grade"
                };
                Console.WriteLine($"Performance : {result}");
            }
            else
            {
                Console.WriteLine("Invalid Input");
            }
            
        }
    }
}
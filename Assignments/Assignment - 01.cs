using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments
{
    public class Assignment_01
    {

        public static void DisplayStudentProfileDetails()
        {
            Console.Write("Enter your Name       : ");
            string? name = Console.ReadLine();
            
            Console.WriteLine($"Name Successful");
            Console.Write("Enter your Age        : ");
            string? age = Console.ReadLine();
            if (int.TryParse(age?.Trim(), out int ageOutput))
            {
                Console.WriteLine("Age Successful");

                if (ageOutput >= 18)
                {
                    Console.WriteLine("Eligible for Adult Admission");
                }
                else
                {
                    Console.WriteLine("Minor Admission");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Enter Age in number (ex: 25)");
            }
            Console.Write("Enter your Percentage : ");
            string? percentage = Console.ReadLine();
            if (double.TryParse(percentage?.Trim(), out double percentageOutput))
            {
                Console.WriteLine("Percentage Successful");

                if (percentageOutput >= 90)
                {
                    Console.WriteLine("Outstanding");
                }
                else if(percentageOutput >= 75)
                {
                    Console.WriteLine("Excellent");
                }
                else if (percentageOutput >= 60)
                {
                    Console.WriteLine("Good");
                }
                else if (percentageOutput >= 35)
                {
                    Console.WriteLine("Clever");
                }
                else
                {
                    Console.WriteLine("Do well Next time Champ");
                }

                
            }
            else
            {
                Console.WriteLine("Invalid Input. Enter Percentage in number (ex: 87.89)");
            }
            Console.Write("Enter your Grade  : ");
            string? grade = Console.ReadLine();
            if (char.TryParse(grade?.Trim().ToUpper() , out char gradeOutput))
            {
                Console.WriteLine("Grade Successful");
                string gradePerformance = gradeOutput switch
                {
                    'A' => "Outstanding Student",
                    'B' => "Excellent Student",
                    'C' => "Good Student",
                    'D' => "Clever Student",
                    _ => "Invalid Grade"
                };

                Console.WriteLine(gradePerformance);
            }
            else
            {
                Console.WriteLine("Invalid Input. Enter Grade as single Character (ex : A)");
            }
            Console.Write("Enter your City       : ");
            string? city = Console.ReadLine();
            Console.Write("Sports Quota (True/False) : ");
            string? isSportsQuota = Console.ReadLine();
            if (bool.TryParse(isSportsQuota?.Trim(), out bool isSportsQuotaOutput))
            {
                Console.WriteLine("Quota Successful");

                if (isSportsQuotaOutput == true)
                {
                    if (percentageOutput >= 60)
                    {
                        Console.WriteLine("Eligible for Sports Scholarship");
                    }
                    else
                    {
                        Console.WriteLine("Sports Quota Available but Academic Criteria Not Met");
                    }
                }
                else
                {
                    Console.WriteLine("General Admission");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }
            Console.WriteLine("");
            Console.WriteLine("----------- Student Profile -----------");
            Console.WriteLine("");
            Console.WriteLine($"Name          :\t{name}\nAge           :\t{ageOutput}");
            Console.WriteLine($"Percentage    :\t{percentage} %\nGrade         :\t{gradeOutput}");
            Console.WriteLine($"City          :\t{city}\nSports Quota  :\t{isSportsQuotaOutput}");
            Console.WriteLine("");
            Console.WriteLine($"Name in UpperCase     : {name?.ToUpper()}");
            Console.WriteLine($"Name in LowerCase     : {name?.ToLower()}");
            Console.WriteLine($"Name Length           : {name?.Length}");
            Console.WriteLine($"Name First Character  : {name?[0]}");
            Console.WriteLine($"Name Last Character   : {name?.Length - 1}");
            Console.WriteLine($"Name Conatin \"Lok\"  : {name?.Contains("Lok")}");
            Console.WriteLine($"Name start with \'L\' : {name?.StartsWith("L")}");
            Console.WriteLine($"Name end with \'h\'   : {name?.EndsWith("h")}");
            Console.WriteLine($"Replace User City     : {city?.Replace("Vijayawada","Hyderabad" )}");
            
        }

        public static void DisplayTypeConversions()
        {
            Console.Write("Enter your Age        : ");
            string? age = Console.ReadLine();
            if (double.TryParse(age?.Trim(), out double ageOutput))
            {
                Console.WriteLine("Age Successful");

                if (ageOutput >= 18)
                {
                    Console.WriteLine("Eligible for Adult Admission");
                }
                else
                {
                    Console.WriteLine("Minor Admission");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input. Enter Age in number (ex: 25)");
            }

            try
            {
                Console.Write("Enter your Percentage : ");
                string? percentage = Console.ReadLine();
                int percentageOutput = Convert.ToInt32(percentage);
                Console.WriteLine(percentageOutput);
                Console.WriteLine(percentageOutput + 5);
                Console.WriteLine(percentageOutput - 5);
                Console.WriteLine(percentageOutput * 2);
                Console.WriteLine(percentageOutput / 2);
                Console.WriteLine(percentageOutput % 2);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine(ex);
            }

            int admissionFee = 50000;
            Console.Write("Sports Quota (True/False) : ");
            string? isSportsQuota = Console.ReadLine();
            if (bool.TryParse(isSportsQuota?.Trim(), out bool isSportsQuotaOutput))
            {
                Console.WriteLine("Quota Successful");

                if (isSportsQuotaOutput == true)
                {
                    Console.WriteLine($"Original fee : {admissionFee}");
                    double discount = admissionFee * 0.20;
                    Console.WriteLine($"Discount     : {discount}");
                    decimal finalFee = admissionFee - (decimal)discount;
                    Console.WriteLine($"Final Fee    : {finalFee}");
                }
                else
                {
                    Console.WriteLine("General Admission");
                }
            }
            else
            {
                Console.WriteLine("Invalid Input.");
            }

        }

    }
}

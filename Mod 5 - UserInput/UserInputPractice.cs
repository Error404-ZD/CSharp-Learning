namespace CSharp.UserInput
{
    public class UserInputPractice
    {

        public static void DisplayStudentDetails1()
        {
            //Using TryParse method
            Console.Write($"Enter your Name : ");
            string? name = Console.ReadLine();
            Console.Write($"Enter your Age  : ");
            string? input = Console.ReadLine();
            bool success = int.TryParse(input, out int Age);
            if (success)
            {

            }
            else
            {
                Console.WriteLine($"Invalid Age : {Age}");
                Console.Write($"Please re-enter your Valid Age (Numbers only!)  : ");
                string? inputValid = Console.ReadLine();
                int ageValid = Convert.ToInt32(inputValid);
            }
            Console.Write($"Enter your City : ");
            string? city = Console.ReadLine();
        }

        public static void DisplayStudentDetails2()
        {
            //Using Convert class 
            Console.Write($"Enter your Name : ");
            string? name = Console.ReadLine();
            try
            {
                Console.Write($"Enter your Age  : ");
                string? input = Console.ReadLine();
                int age = Convert.ToInt32(input);
            }
            catch (FormatException result)
            {
                Console.WriteLine($"{result.Message}");
                Console.Write($"Please re-enter your Valid Age (Numbers only!)  : ");
                string? inputValid = Console.ReadLine();
                int ageValid = Convert.ToInt32(inputValid);
            }
            
            Console.Write($"Enter your City : ");
            string? city = Console.ReadLine();
        }

        public static void DisplayCalculatorInputDetails1()
        {
            
            Console.Write($"Input - 1  : ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Input - 2  : ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double output1 = input1 + input2;
            Console.WriteLine($"Sum of {input1} and {input2} is        : {output1}");
            double output2 = input1 - input2;
            Console.WriteLine($"Difference of {input1} and {input2} is : {output2}");
            double output3 = input1 * input2;
            Console.WriteLine($"Product of {input1} and {input2} is    : {output3}");
            double output4 = input1 / input2;
            Console.WriteLine($"Division of {input1} and {input2} is   : {output4}");
            double output5 = input1 % input2;
            Console.WriteLine($"Modulus of {input1} and {input2} is    : {output5}");

        }

        public static void DisplayEmployeeDetails()
        {
            Console.Write($"Enter your Name                     : ");
            string? name = Console.ReadLine();
            Console.Write($"Enter your Salary                   : ");
            decimal salary = Convert.ToDecimal(Console.ReadLine());
            Console.Write($"Permanent Employee (True/False) : ");
            bool isPermanent = Convert.ToBoolean(Console.ReadLine());

        }

        public static void DisplayGradeInputDetails()
        {

            Console.Write($"Enter grade : ");
            char grade = Convert.ToChar(Console.ReadLine()![0]);
            Console.WriteLine($"Grade is : {grade}");
        }

        public static void DisplayInputValidationDetails()
        {
            Console.Write($"Enter Age : ");
            string? output = Console.ReadLine();
            bool success = double.TryParse(output, out double result);
            if(success)
            {
                Console.WriteLine($"Welcome!");
            }
            else
            {
                Console.WriteLine($"Invalid age entered");
            }
        }

        public static void DisplayStudentRegistrationDetails()
        {

            Console.Write($"Enter Name : ");
            string? name = Console.ReadLine();
            Console.Write($"Enter Age  : ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write($"Enter Percentage : ");
            double percentage = Convert.ToDouble(Console.ReadLine());
            Console.Write($"Enter grade : ");
            char grade = Console.ReadLine()![0];
            Console.WriteLine($"Grade is : {grade}");
            Console.Write($"Placed (True/False) :  ");
            bool placed = Convert.ToBoolean(Console.ReadLine());
        }

    }
}

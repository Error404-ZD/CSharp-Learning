namespace CSharp.Variables
{
    public class VariablePractice
    {

        public static void DisplayDeclaredVariables()
        {

            string name = "Lokesh reddy Buchi";
            int age = 25;
            int heightInCm = 164;
            double weightInkg = 55;
            bool isStudent = true;

            Console.WriteLine($"Name    : {name}");
            Console.WriteLine($"Age     : {age}");
            Console.WriteLine($"Height  : {heightInCm} cm");
            Console.WriteLine($"Weight  : {weightInkg} kg");
            Console.WriteLine($"Student : {isStudent}");
        }

        public static void UpdateVariableValues()
        {
            int marks = 40;
            Console.WriteLine($"Marks before update       : {marks}");
            marks = 50;
            Console.WriteLine($"Marks after update        : {marks}");
            marks = 60;
            Console.WriteLine($"Marks after second update : {marks}");
            marks = 70;
            Console.WriteLine($"Marks after third update  : {marks}");
            marks = 80;
            Console.WriteLine($"Marks after fourth update : {marks}");
            marks += 10;
            Console.WriteLine($"Marks after fifth update  : {marks}");
            marks -= 10;
            Console.WriteLine($"Marks after sixth update  : {marks}");

        }

        /* Naming conventions for variables in C#:
         * 1. Use camelCase for local variables and parameters.
         * 2. Use PascalCase for public properties and methods.
         * 3. Use descriptive names that indicate the purpose of the variable.
         * 
         * Identify which variable names are valid and which are invalid. Explain why.
         * int age; - Valid: follows camelCase convention.
           int Age; - Valid: follows PascalCase convention. (Note: PascalCase is typically used for public properties, not local variables.)
           int studentAge; - Valid: follows camelCase convention.
           int student_age; - valid: uses underscore, which is not recommended in C# naming conventions.
           int 1student; - Invalid: cannot start with a digit.
           int student1; - Valid: follows camelCase convention and can end with a digit.
           int first name; - Invalid: contains a space, which is not allowed in variable names.
           int @class; - Valid: uses the @ symbol to allow a reserved keyword as a variable name, but it's not recommended to use reserved keywords as variable names.

        
         */

        public static void DisplayStudentProfile()
        {
            string name = "Lokesh reddy Buchi";
            int age = 25;
            string collegeName = "Vignan's Foundation for Science, Technology and Research";
            string branch = "Computer Science and Engineering";
            double percentage = 75.0;
            string phoneNumber = "123-456-7890";
            string city = "Hyderabad";
            bool isGraduated = true;

            Console.WriteLine($"Name         : {name}");
            Console.WriteLine($"Age          : {age}");
            Console.WriteLine($"College Name : {collegeName}");
            Console.WriteLine($"Branch       : {branch}");
            Console.WriteLine($"Percentage   : {percentage}%");
            Console.WriteLine($"Phone Number : {phoneNumber}");
            Console.WriteLine($"City         : {city}");
            Console.WriteLine($"Graduated    : {isGraduated}");

        }

        /* 
         * Assignment 5: Think Before Coding

           For each item below, decide which data type would be appropriate (don't worry if you haven't learned all data types yet—make your best guess):

           Number of students in a class - > int
           Price of a laptop - > decimal
           Person's name - > string
           Whether a light is ON or OFF - > bool
           Grade ('A', 'B', 'C') - > char
           Mobile number - > string (to accommodate formatting and leading zeros)

        */
    }
}

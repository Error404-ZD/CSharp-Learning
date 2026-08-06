namespace CSharp.DataTypes
{
    public class DataTypesPractice
    {

        public static void DisplayDataTypes()
        {
            // Displaying the size of different data types in bytes
            Console.WriteLine($"Size of byte    : {sizeof(byte)} bytes");
            Console.WriteLine($"Size of short   : {sizeof(short)} bytes");
            Console.WriteLine($"Size of int     : {sizeof(int)} bytes");
            Console.WriteLine($"Size of long    : {sizeof(long)} bytes");
            Console.WriteLine($"Size of float   : {sizeof(float)} bytes");
            Console.WriteLine($"Size of double  : {sizeof(double)} bytes");
            Console.WriteLine($"Size of decimal : {sizeof(decimal)} bytes");
            Console.WriteLine($"Size of char    : {sizeof(char)} bytes");
            Console.WriteLine($"Size of bool    : {sizeof(bool)} bytes");


        }

        public static void PrintDataTypes()
        {
            byte byteValue = 255;
            short shortValue = 32767;
            int intValue = 2147483647;
            long longValue = 9223372036854775807L;
            float floatValue = 3.14f;
            double doubleValue = 3.141592653589793;
            decimal decimalValue = 3.1415926535897932384626433832m;
            char charValue = 'A';
            string stringValue = "Hello, World!";
            bool boolValue = true;

            Console.WriteLine($"byteValue    : {byteValue}");
            Console.WriteLine($"shortValue   : {shortValue}");
            Console.WriteLine($"intValue     : {intValue}");
            Console.WriteLine($"longValue    : {longValue}");
            Console.WriteLine($"floatValue   : {floatValue}");
            Console.WriteLine($"doubleValue  : {doubleValue}");
            Console.WriteLine($"decimalValue : {decimalValue}");
            Console.WriteLine($"charValue    : {charValue}");
            Console.WriteLine($"stringValue  : {stringValue}");
            Console.WriteLine($"boolValue    : {boolValue}");
        }

        public static void DisplayStudentProfile()
        {

            string name = "Lokesh reddy Buchi";
            int age = 25;
            int heightInCm = 164;
            double weightInKg = 55;
            double percentage = 92.5;
            char grade = 'A';
            string phoneNumber = "123-456-7890";
            bool isGraduated = true;
            Console.WriteLine($"Name         : {name}");
            Console.WriteLine($"Age          : {age}");
            Console.WriteLine($"Height       : {heightInCm} cm");
            Console.WriteLine($"Weight       : {weightInKg} kg");
            Console.WriteLine($"Percentage   : {percentage}%");
            Console.WriteLine($"Grade        : {grade}");
            Console.WriteLine($"Phone Number : {phoneNumber}");
            Console.WriteLine($"Graduated    : {isGraduated}");

        }

        /*
         * Find the Errors

           Identify and fix the errors:

           int price = 99.99; - Invalid: cannot assign a decimal value to an int variable. It should be decimal.

           char letter = "A"; - Invalid: char should be assigned a single character using single quotes, not double quotes. It should be char letter = 'A';

           string name = 'Lokesh'; - Invalid: string should be assigned a sequence of characters using double quotes, not single quotes. It should be string name = "Lokesh";

           float weight = 75.5; - Invalid: float literals should have an 'f' suffix. It should be float weight = 75.5f;

           decimal salary = 50000.75; - Invalid: decimal literals should have an 'm' suffix. It should be decimal salary = 50000.75m;

           bool value = "true"; - Invalid: bool should be assigned a boolean value using true or false, not a string. It should be bool value = true;

           Explain why each line is wrong.
        */

        /*
         * Data Types in C#:
         * 
         * 1. Value Types: These types hold data directly and are stored in the stack memory. Examples include:
         *    - int, float, double, decimal, char, bool, struct, enum
         * 
         * 2. Reference Types: These types hold a reference to the data and are stored in the heap memory. Examples include:
         *    - string, class, array, delegate
         * 
         * 3. Nullable Types: These types can represent all the values of its underlying value type plus an additional null value. Example:
         *    - int?, double?, bool?
         * 
         * 4. Object Type: The base type from which all other types derive. It can hold any data type.
         *    - object
         * 
         * 5. Dynamic Type: This type bypasses compile-time type checking and resolves type at runtime.
         *    - dynamic
        */

        /*
         * Choose the Correct Data Type

           Choose the best data type for:

           Roll Number - int
           Passport Number - string
           Temperature - double
           Product Price - decimal
           Currency Exchange Rate - decimal
           Gender (single character) - char
           Email Address - string
           Number of Employees - int
           Is Email Verified - bool
           Total Distance to the Moon - double

         */

        public static void CompareCharAndString()
        {

            char letter = 'A';
            string word = "A";
            Console.WriteLine($"Char: {letter}, String: {word}");
        }


        public static void DisplayDataTypeRanges()
        {
            Console.WriteLine($"Range of byte    : {byte.MinValue} to {byte.MaxValue}");
            Console.WriteLine($"Range of short   : {short.MinValue} to {short.MaxValue}");
            Console.WriteLine($"Range of int     : {int.MinValue} to {int.MaxValue}");
            Console.WriteLine($"Range of long    : {long.MinValue} to {long.MaxValue}");
            Console.WriteLine($"Range of float   : {float.MinValue} to {float.MaxValue}");
            Console.WriteLine($"Range of double  : {double.MinValue} to {double.MaxValue}");
            Console.WriteLine($"Range of decimal : {decimal.MinValue} to {decimal.MaxValue}");
            Console.WriteLine($"Range of char    : {char.MinValue} to {char.MaxValue}");
            Console.WriteLine($"Range of bool    : {bool.FalseString} or {bool.TrueString}");
            Console.WriteLine($"Range of string  : {string.Empty} to {new string(char.MaxValue, 1)}");
            Console.WriteLine($"Range of object  : {object.ReferenceEquals(null, null)} to {object.ReferenceEquals(new object(), new object())}");
            //Console.WriteLine($"Range of dynamic : {dynamic.MinValue} to {dynamic.MaxValue}");
            Console.WriteLine($"Range of DateTime: {DateTime.MinValue} to {DateTime.MaxValue}");
            Console.WriteLine($"Range of TimeSpan: {TimeSpan.MinValue} to {TimeSpan.MaxValue}");

        }

        public static void DisplayDoublePrecision()
        {
            double value1 = 0.1;
            double value2 = 0.2;
            double sum = value1 + value2;
            Console.WriteLine($"Value 1: {value1}");
            Console.WriteLine($"Value 2: {value2}");
            Console.WriteLine($"Sum    : {sum}");
            Console.WriteLine($"Is sum equal to 0.3? {sum == 0.3}");





        }
    }
}
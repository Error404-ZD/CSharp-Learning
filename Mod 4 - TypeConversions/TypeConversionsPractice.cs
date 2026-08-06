using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.TypeConversions
{
    public class TypeConversionsPractice
    {

        public static void DisplayImplicitTypeConversions()
        {
            // Implicit type conversion (widening conversion)
            byte byteValue = 100;
            int intValue = byteValue; // byte to int
            Console.WriteLine($"Implicit Conversion : byte {byteValue} to int {intValue}");
            int intValue1 = 255;
            long longValue = intValue1; // int to long
            Console.WriteLine($"Implicit Conversion : int {intValue1} to long {longValue}");
            float floatValue = 3.14f;
            double doubleValue = floatValue; // float to double
            Console.WriteLine($"Implicit Conversion : float {floatValue} to double {doubleValue}");

        }

        public static void DisplayExplicitTypeConversions()
        {
            // Explicit type conversion (narrowing conversion)
            double doubleValue = 3.14159;
            int intValue = (int)doubleValue; // double to int 
            Console.WriteLine($"Explicit Conversion : double {doubleValue} to int {intValue}");
            long longValue = 10000000000L;
            short shortValue = (short)longValue; // long to short
            Console.WriteLine($"Explicit Conversion : long {longValue} to short {shortValue}");
        }


        public static void DisplayConvertClassConversions()
        {
            // using Convert class for type conversion
            double doubleValue = 100.45689;
            int intValue = Convert.ToInt32(doubleValue); // double to int
            Console.WriteLine($"Convert Class Conversion : double {doubleValue} to int {intValue}");
            long longValue = 123456789;
            string stringValue = Convert.ToString(longValue); // long to string
            Console.WriteLine($"Convert Class Conversion : long {longValue} to string {stringValue}");
            string stringValue1 = "12345.90876";
            double doubleValue1 = Convert.ToDouble(stringValue1); // string to double
            Console.WriteLine($"Convert Class Conversion : string {stringValue1} to double {doubleValue1}");
            decimal decimalValue = 123.456m;
            bool boolValue = Convert.ToBoolean(decimalValue); // decimal to bool
            Console.WriteLine($"Convert Class Conversion : decimal {decimalValue} to bool {boolValue}");

        }


        public static void DisplayParsingConversions()
        {
            // using Parse method for type conversion
            string stringValue = "1002";
            int intValue = int.Parse(stringValue); // string to int
            Console.WriteLine($"Parse Method Conversion : string {stringValue} to int {intValue}");
            string stringValue1 = "99.99";
            double doubleValue = double.Parse(stringValue1); // string to double
            Console.WriteLine($"Parse Method Conversion : string {stringValue1} to double {doubleValue}");
            string stringValue2 = "true";
            bool boolValue1 = bool.Parse(stringValue2);
            Console.WriteLine($"Parse Method Conversion : string {stringValue2} to bool {boolValue1}");


        }

        public static void DisplayTryParseConversions()
        {
            // using TryParse method for type conversion
            string input = "25";
            bool success = int.TryParse(input, out int number );
            if(success)
            {
                Console.WriteLine($"the input is valid and the result is   : {number}");
            }
            else
            {
                Console.WriteLine($"the input is invalid and the result is : {number}");
            }
            string input1 = "twenty five";
            bool fail = int.TryParse(input1, out int result);
            if(fail)
            {
                Console.WriteLine($"the input is valid and the result is   : {result}");
            }
            else
            {
                Console.WriteLine($"the input is invalid and the result is : {result}");
            }

        }


        public static void DisplayOverflowException()
        {
            //using checked 
            try
            {
                checked
                {
                    byte number = 255;
                    number++;
                }
            }
            catch (OverflowException ex)
            {
                Console.WriteLine(ex.Message);
            }
            //using unchecked
            unchecked
            {
                byte byteValue = 255;
                ++byteValue;
                byteValue++;
            }
        }



    }
}

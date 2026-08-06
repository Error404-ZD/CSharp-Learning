namespace CSharp.Operators
{
    public class OperatorsPractice
    {

        public static void DisplayArithmeticOperators()
        {
            //Mathematical operations using arithmetic operators
            int a = 7;
            int b = 22;

            Console.WriteLine($"Addition of {a} and {b} is       : {a + b}");
            Console.WriteLine($"Subtraction of {a} and {b} is    : {a - b}");
            Console.WriteLine($"Multiplication of {a} and {b} is : {a * b}");
            Console.WriteLine($"Division of {a} and {b} is       : {(double)a / b}");
            Console.WriteLine($"Modulus of {a} and {b} is        : {a % b}");

        }

        public static void DisplayAssignmentOperators()
        {
            //assigns a value to a variable and then performs an operation on that variable
            double marks = 44.0;
            Console.WriteLine($"Marks before update : {marks}");
            marks += 6;
            Console.WriteLine($"Marks after += 6    : {marks}");
            marks -= 10;
            Console.WriteLine($"Marks after -= 10   : {marks}");
            marks *= 3;
            Console.WriteLine($"Marks after *= 3    : {marks}");
            marks /= 4;
            Console.WriteLine($"Marks after /= 4    : {marks}");
            marks %= 5;
            Console.WriteLine($"Marks after %= 5    : {marks}");

        }

        public static void DisplayComparisonOperators()
        {
            //compares two values and returns a boolean result
            int a = 10;
            double b = 20.5;

            Console.WriteLine($"Is {a} equal to {b}                 : {a == b}");
            Console.WriteLine($"Is {a} not equal to {b}             : {a != b}");
            Console.WriteLine($"Is {a} greater than {b}             : {a > b}");
            Console.WriteLine($"Is {a} less than {b}                : {a < b}");
            Console.WriteLine($"Is {a} greater than or equal to {b} : {a >= b}");
            Console.WriteLine($"Is {a} less than or equal to {b}    : {a <= b}");

        }

        public static void DisplayLogicalOperators()
        {
            //performs logical operations on boolean values and returns a boolean result
            bool hasLicense = true;
            bool hasHelmet = false;
            Console.WriteLine($"Has license and helmet : {hasLicense && hasHelmet}");
            Console.WriteLine($"Has license or helmet  : {hasLicense || hasHelmet}");
            Console.WriteLine($"Does not have license  : {!hasLicense}");
            Console.WriteLine($"Does not have helmet   : {!hasHelmet}");
        }

        public static void DisplayIncrementAndDecrementOperators()
        {
            //increments or decrements the value of a variable by 1 and returns the value before or after the operation
            int count = 5;
            Console.WriteLine($"Initial value of count              : {count}");
            Console.WriteLine($"Post-increment of count             : {count++}");
            Console.WriteLine($"Value of count after post-increment : {count}");
            Console.WriteLine($"Pre-increment of count              : {++count}");
            Console.WriteLine($"Value of count after pre-increment  : {count}");
            Console.WriteLine($"Post-decrement of count             : {count--}");
            Console.WriteLine($"Value of count after post-decrement : {count}");
            Console.WriteLine($"Pre-decrement of count              : {--count}");
            Console.WriteLine($"Value of count after pre-decrement  : {count}");
        }




    }

}

/*
* Topic: Operators
*
* Covered:
* ✔ Arithmetic Operators
* ✔ Assignment Operators
* ✔ Comparison Operators
* ✔ Logical Operators
* ✔ Increment Operators
* ✔ Decrement Operators
* ✔ Integer Division
* ✔ Compound Assignment
*
* Pending:
* ⏳ Bitwise Operators
* ⏳ Ternary Operator
* ⏳ Null-Coalescing Operators
* ⏳ Pattern Matching Operators 

Bitwise
&
|
^
~
<<
>>

Null-coalescing
??

Null-coalescing assignment
??=

Conditional (ternary)
?:

Null conditional
?.
?[]

Pattern matching
is

Type checking
as

Lambda
=>

Range
..

Index
^

Switch expressions

Checked / unchecked

*/


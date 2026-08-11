using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments
{
    public class Assignment_03
    {
        public static void PrintAllNumbers()
        {
            int[] numbers =
            {
                89,
                90,
                56,
                47,
                56,
                96,
                36,
                89,
                90,
                56,
                47,
                56,
                96,
                36
            };
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        public static void UpdateAnElement()
        {
            int[] numbers =
            {
                89,
                90,
                56,
                47,
                56,
                96,
                36,
                89,
                90,
                56,
                47,
                56,
                96,
                36
            };
            for (int i = 0; i <= numbers.Length - 1; i++)
            {
                Console.Write($"{numbers[i]} ");
            }
            Console.WriteLine();
            numbers[7] = 100;
            foreach (int number in numbers)
            {
                Console.Write($"{number} ");
            }
            Console.WriteLine();
        }

        public static void PrintFirstAndLastElement()
        {
            int[] numbers =
            {
                89,
                90,
                56,
                47,
                56,
                96,
                36,
                89,
                90,
                56,
                47,
                56,
                96,
                36
            };
            Console.WriteLine($"{numbers[0]}\n{numbers[numbers.Length-1]}");
        }

        public static void PrintHighestLowestSumAverage()
        {
            int[] numbers =
            {
                89, 90, 56, 47, 56, 96, 36, 89, 90, 56, 47, 56, 96, 36
            };

            int highest = numbers[0];
            int lowest = numbers[0];
            int sum = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                int current = numbers[i];
                if (current > highest) highest = current;
                if (current < lowest) lowest = current;
                sum += current;
            }

            double average = (double)sum / numbers.Length;

            Console.WriteLine($"Highest : {highest}");
            Console.WriteLine($"Lowest  : {lowest}");
            Console.WriteLine($"Sum     : {sum}");
            Console.WriteLine($"Average : {average}");
        }

        public static void CountEvenAndOddNumbers()
        {
            int[] numbers =
            {
                89, 90, 56, 47, 56, 96, 36, 89, 90, 56, 47, 56, 96, 36
            };

            int evenCount = 0;
            int oddCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0) evenCount++;
                else oddCount++;
            }
            Console.WriteLine($"Even Numbers Count is : {evenCount}");
            Console.WriteLine($"Odd Numbers Count is  : {oddCount}");
        }

        public static void SearchAnElemenet()
        {
            char[] characters =
            {
                'L','o','k','E','S','h','k'
            };
            char search = 'k';
            char results = Array.Find(characters,c => c == search);// since, i dont know lambda expressions yet i copied the provided example syntax and instead of int[] i tried char[].
            Console.WriteLine(results);
        }
        public static void ReverseAnArray()
        {
            char[] characters =
            {
                'l','o','k','e','s','h','k'
            };
            Array.Reverse(characters);                      
            Console.WriteLine(characters);      
        }

        public static void CopyAnArray()
        {
            /* char[] characters =
             {
                 'l','o','k','e','s','h','k'
             };
             int[] numbers =
             {
                 89, 90, 56, 47, 56, 96, 36, 89, 90, 56, 47, 56, 96, 36
             };
             Array.Copy(characters, numbers, characters.Length);
             Console.WriteLine(string.Join(", ", numbers));*/
            char[] source =
             {
               'L','o','k'
             };

            char[] destination =
            new char[source.Length];

            Array.Copy(source, destination, source.Length);
        }
        public static void SortAscendingAndDescending()
        {
            int[] numbers =
            {
                89, 90, 56, 47, 56, 96, 36, 89, 90, 56, 47, 56, 96, 36
            };
            Array.Sort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Ascending order  : {numbers[i]}");
            }
            Console.WriteLine();
            //Array.Reverse(numbers);
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"Descending order : {numbers[i]}");
            }
        }

        public static void CountVowelsAndConsonantsInAName()//improve after exception handling refer module - 11.5
        {
            string exit = "exit";

            while (true)
            {
                Console.Write($"Enter Password : ");
                string? name = Console.ReadLine();
                name = name!.ToLower();
                if (name.Equals(exit, StringComparison.OrdinalIgnoreCase)) break;
                char[] convert = name!.ToCharArray();
                int vowelCount = 0;
                int consonantsCount = 0;
                int digitCount = 0;
                int spacesCount = 0;
                int punctuationCount = 0;
                int symbolsCount = 0;
                for (int i = 0; i < convert.Length; i++)
                {
                    char c = convert[i];
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') vowelCount++;
                    else if (char.IsLetter(c)) consonantsCount++;
                    else if (char.IsDigit(c)) digitCount++;
                    else if (c == ' ') spacesCount++;
                    else if (char.IsPunctuation(c)) punctuationCount++;
                    else if (char.IsSymbol(c)) symbolsCount++;
                }
                Console.WriteLine($"Number of vowels in {name}        : {vowelCount}");
                Console.WriteLine($"Number of Consonants in {name}    : {consonantsCount}");
                Console.WriteLine($"Number of Digits in {name}        : {digitCount}");
                Console.WriteLine($"Number of Spaces in {name}        : {spacesCount}");
                Console.WriteLine($"Number of Punctuations in {name}  : {punctuationCount}");
                Console.WriteLine($"Number of Symbols in {name}       : {symbolsCount}");
            }
        }

        public static void ReverseStringManually()
        {
            Console.Write($"Enter Name : ");
            string? name = Console.ReadLine();
            char[] convert = name!.ToCharArray();
            string reverse = "";
            for (int i = convert.Length - 1; i >= 0; i--)
            {
                reverse = reverse + convert[i];
            }
            Console.WriteLine(reverse);
        }
    }
}

namespace CSharp.Strings
{
    public class StringsPractice
    {

        public static void DisplayCreatedStrings()
        {

            string name = "Lokesh";
            string city = "Vijayawada";
            string country = "India";
            string favouriteProgrammingLanguage = "C#";
            string message = $"I am {name}! and I am from {city},{country}. My favourite programming language is {favouriteProgrammingLanguage}";

            Console.WriteLine(message);
        }

        public static void DisplayEscapeSequences()
        {

            string name = "Lokesh";
            string city = "Vijayawada";
            string country = "India";
            string favouriteProgrammingLanguage = "C#";
            string message = $"I am \"{name}\"!\nI am from {city},\t{country}.\tMy favourite programming language is \\{favouriteProgrammingLanguage}\\";

            Console.WriteLine(message);
        }

        public static void DisplayVerbatimStrings()
        {

            string filePathUsingNormalString = "C:\\Users\\Lokesh\\Documents\\Test.txt";
            string filePathUsingVerbatimString = @"C:\Users\Lokesh\Documents\Test.txt";

            Console.WriteLine($"File Path 1 : {filePathUsingNormalString}");
            Console.WriteLine($"File Path 2 : {filePathUsingVerbatimString}");
        }

        public static void DisplayRawStringLiterals()
        {

            string json = """
                {
                  "Name": "Lokesh",
                  "Age" : 25,
                  "City": "Vijayawada"
                }
                """;

            Console.WriteLine($"JSON: {json}");
        }

        public static void DisplayStringInterpolation()
        {

            string name = "Lokesh Reddy Buchi";
            int age = 25;
            string city = "Vijayawada";

            Console.WriteLine($"Name : {name}\nAge  : {age}\nCity : {city}");
        }

        public static void DisplayStringConcatenation()
        {

            string firstName = "Lokesh";
            string middleName = "Reddy";
            string lastName = "Buchi";

            string usingPlus = firstName + " " + middleName + " " + lastName;
            string usingConcat = string.Concat(firstName, " " ,middleName, " " ,lastName);
            string usingJoin = string.Join(" ", firstName, middleName, lastName);

            Console.WriteLine($"Full Name using '+'               : {usingPlus}");
            Console.WriteLine($"Full Name using 'string.Concat()' : {usingConcat}");
            Console.WriteLine($"Full Name using 'string.Join()'   : {usingJoin}");

        }

        public static void DisplayStringLength()
        {

            string name = "Lokesh Reddy Buchi";
            string city = "Vijayawada";
            string programmingLanguage = "C#";

            Console.WriteLine($"Length of String Name                : {name.Length}");
            Console.WriteLine($"Length of String City                : {city.Length}");
            Console.WriteLine($"Length of String ProgrammingLanguage : {programmingLanguage.Length}");
        }

        public static void DisplayStringIndexes()
        {

            string name = "Lokesh Reddy Buchi";

            char firstCharacter = name[0];
            char secondCharacter = name[1];
            char lastCharacter = name[name.Length-1];

            Console.WriteLine($"First, Second and last Character of name : {firstCharacter}, {secondCharacter} and {lastCharacter}");
        }

        public static void DisplayCaseConversion()
        {

            string fullName = "Lokesh Reddy Buchi";
            string originalName = fullName;
            string upperCaseName = fullName.ToUpper();
            string lowerCaseName = fullName.ToLower();
            bool ifFullNameEquals = fullName.Equals(upperCaseName);

            Console.WriteLine($"{originalName}\n{upperCaseName}\n{lowerCaseName}");
            Console.WriteLine(ifFullNameEquals);
        }

        public static void DisplayRemoveSpaces()
        {

            string name = "    Lokesh Reddy Buchi        ";
            string trim = name.Trim();
            string trimStart = name.TrimStart();
            string trimEnd = name.TrimEnd();

            Console.WriteLine($"'{trim}'\n'{trimStart}'\n'{trimEnd}'");
        }

        public static void DisplaySearchText()
        {

            string sentence = "OperatorsPractice . DisplayIncrementAndDecrementOperators() ;";
            bool contains = sentence.Contains("Increment");
            bool startsWith = sentence.StartsWith("OperatorsPractice");
            bool endsWith = sentence.EndsWith(";");
            Console.WriteLine($"{contains}\n{startsWith}\n{endsWith}");
        }

        public static void DisplayReplacedText()
        {

            string sentence = "I love Java";
            string replace = sentence.Replace("Java", "Q#");
            Console.WriteLine($"{sentence}\n{replace}");
        }

        public static void DisplayExtractedText()
        {

            string text = "AutomationTesting";
            string subString = text.Substring(4, 10);
            int indexOf = text.IndexOf('T');
            int lastIndexOf = text.LastIndexOf('i');
            Console.WriteLine($"{subString}\n{indexOf}\n{lastIndexOf}");

        }

        public static void DisplaySplitText()
        {

            string text = "Apple,Banana,Mango,Orange";
            string[] split = text.Split(',');
            Console.WriteLine($"{split[0]}\n{split[1]}\n{split[2]}\n{split[3]}");
        }

        public static void DisplayInsertAndRemove()
        {

            string name = "Lokesh";
            string fullName = name.Insert(6, " Reddy Buchi");
            string remove = name.Remove(3,3);
            Console.WriteLine($"{fullName}\n{remove}");
        }

        public static void DisplayPadding()
        {

            string text = "30";
            string padLeft = text.PadLeft(3, '0');
            string note = "I D ";
            string padRight = note.PadRight(5,'C');
            Console.WriteLine($"{padLeft}\n{padRight}");
        }

        public static void DisplayValidateInput()
        {

            string? nothing = null;
            string empty = "";
            string emptySpaces = "      ";
            Console.WriteLine($"{string.IsNullOrEmpty(nothing)}\n{string.IsNullOrWhiteSpace(nothing)}");
            Console.WriteLine($"{string.IsNullOrEmpty(empty)}\n{string.IsNullOrWhiteSpace(empty)}");
            Console.WriteLine($"{string.IsNullOrEmpty(emptySpaces)}\n{string.IsNullOrWhiteSpace(emptySpaces)}");
        }

        public static void DisplayCaseSensitiveComparison()
        {

            string name = "Lokesh";
            bool output = name.Equals("lokesh", StringComparison.OrdinalIgnoreCase);
            bool output2 = name.Equals("lokesh", StringComparison.Ordinal);
            Console.WriteLine($"{output}\n{output2}");
        }

        public static void DisplayUsernameValidation()
        {
            string storedUsername = "Lokesh";
            Console.Write("Enter UserName : ");
            string? enteredUsername = Console.ReadLine();

            if (storedUsername.Equals(enteredUsername, StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine("Login Successful");
            }
            else
            {
                Console.WriteLine("Invalid Username");
            }
        }

    }
}

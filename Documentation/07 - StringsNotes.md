# 📘 Module 6 – Strings (Modern C# 2026)

## What You'll Learn

- Creating strings
- Escape sequences
- Verbatim strings (`@`)
- Raw String Literals (`"""`) ⭐
- String interpolation
- String concatenation
- String Length
- String Indexing
- Common String Methods
- String Comparison

---

# 1. What is a String?

Before understanding strings, let's look at a real-life example.

Imagine you're filling an online registration form.

```
Name
City
Email
```

These values contain **text**, not numbers.

A computer needs a way to store text.

That's where **strings** come in.

## Definition

A **string** is a sequence of Unicode characters used to store text. Specifically encoded using UTF - 16.
(UTF stands for Unicode Transformation Format.)
(It is the system that translates Unicode numbers (code points) into binary data (0s and 1s) so a computer can save, read, and send text.)
(While Unicode is the master list of characters and their assigned numbers, UTF is the mechanism that actually stores those numbers in memory.)
(The Big Problem UTF Solves : Every Unicode character has a number.) 
(For example:The letter A is number 65.The emoji 😂 is number 128,514.)
(If a computer stored every single character using the maximum amount of space needed for a huge emoji number, simple English text files would become four times larger than necessary.) 
(UTF solves this by using space efficiently.)
Example:

```csharp
string name = "Lokesh";
```

Here,

- `string` → Data type
- `name` → Variable
- `"Lokesh"` → String value

---

# 2. Why Do We Need Strings?

Imagine C# had no string type.

How would you store:

```
Lokesh
```

Would you use an `int`?

No.

Would you use a `double`?

No.

Would you use a `bool`?

No.

Numbers store numbers.

Booleans store true/false.

Characters store only one character.

We need a type that stores **multiple characters together**.

That is the purpose of `string`.

---

# 3. Difference Between char and string

`char`

Stores exactly one character.

```csharp
char grade = 'A';
```

`string`

Stores one or more characters.

```csharp
string grade = "A";
```

Examples

```csharp
char letter = 'L';

string name = "Lokesh";
```

| char | string |
|------|---------|
| Single character | Multiple characters |
| Single quotes `' '` | Double quotes `" "` |
| Example: `'A'` | Example: `"Apple"` |

---

# 4. Creating Strings

## Declaration

```csharp
string name;
```

Creates a string variable.

---

## Initialization

```csharp
string name = "Lokesh";
```

Declaration and initialization together.

---

## Empty String

```csharp
string message = "";
```

Contains zero characters.

---

## Null String (Preview)

```csharp
string? email = null;
```

We'll properly learn nullable reference types later.

---

# 5. Escape Sequences

Sometimes you need special characters inside a string.

Escape sequences begin with a backslash (`\`).

## New Line

```csharp
Console.WriteLine("Hello\nWorld");
```

Output

```
Hello
World
```

---

## Tab

```csharp
Console.WriteLine("Name\tAge");
```

Output

```
Name    Age
```

---

## Double Quotes

```csharp
Console.WriteLine("He said \"Hello\"");
```

Output

```
He said "Hello"
```

---

## Backslash

```csharp
Console.WriteLine("C:\\Users\\Lokesh");
```

Output

```
C:\Users\Lokesh
```

---

## Single Quote

```csharp
Console.WriteLine("It's a nice day.");
```

Normally no escaping is needed in a string, but you can write:

```csharp
Console.WriteLine("It\'s a nice day.");
```

---

# 6. Verbatim Strings (`@`)

Verbatim strings ignore escape sequences.

Useful for Windows paths.

Without `@`

```csharp
string path = "C:\\Users\\Lokesh\\Documents";
```

With `@`

```csharp
string path = @"C:\Users\Lokesh\Documents";
```

Much easier to read.

Also useful for multi-line text.

```csharp
string text = @"Hello
Welcome
Goodbye";
```

---

# 7. Raw String Literals (`"""`) ⭐

Introduced in modern C#.

Useful for:

- JSON
- XML
- SQL
- HTML
- Test Data

Example

```csharp
string json = """
{
    "Name": "Lokesh",
    "Age": 25
}
""";
```

No escaping required.

---

# 8. String Interpolation

Old Style

```csharp
Console.WriteLine("Name: " + name);
```

Modern Style

```csharp
Console.WriteLine($"Name: {name}");
```

The `$` allows variables to be inserted directly into the string.

This is the preferred approach in modern C#.

---

# 9. String Concatenation

Joining multiple strings together.

Using `+`

```csharp
string firstName = "Lokesh";
string lastName = "Reddy";

string fullName = firstName + " " + lastName;
```

Using `string.Concat()`

```csharp
string fullName = string.Concat(firstName, " ", lastName);
```

Using `string.Join()`

```csharp
string fullName = string.Join(" ", firstName, lastName);
```

---

# 10. String Length

Returns the total number of characters.

```csharp
string name = "Lokesh";

Console.WriteLine(name.Length);
```

Output

```
6
```

---

# 11. String Indexing

Every character has an index.

```
L o k e s h
0 1 2 3 4 5
```

Example

```csharp
string name = "Lokesh";

Console.WriteLine(name[0]);
Console.WriteLine(name[3]);
```

Output

```
L
e
```

---

# 12. Common String Methods

We'll learn these in detail.

### Case Conversion

- `ToUpper()`
- `ToLower()`

### Removing Spaces

- `Trim()`
- `TrimStart()`
- `TrimEnd()`

### Searching

- `Contains()`
- `StartsWith()`
- `EndsWith()`

### Replacing

- `Replace()`

### Extracting

- `Substring()`

### Splitting

- `Split()`

### Inserting

- `Insert()`

### Removing

- `Remove()`

### Finding Position

- `IndexOf()`
- `LastIndexOf()`

### Padding

- `PadLeft()`
- `PadRight()`

### Validation

- `string.IsNullOrEmpty()`
- `string.IsNullOrWhiteSpace()`

---

# 13. String Comparison

Compare two strings.

Using `==`

```csharp
string a = "Lokesh";
string b = "Lokesh";

Console.WriteLine(a == b);
```

Using `Equals()`

```csharp
Console.WriteLine(a.Equals(b));
```

Case-insensitive comparison

```csharp
Console.WriteLine(
    a.Equals(b, StringComparison.OrdinalIgnoreCase));
```

We'll also learn:

- `StringComparison.Ordinal`
- `StringComparison.OrdinalIgnoreCase`

These are preferred in modern C# because they produce predictable results.

---

# Real-World Automation Examples

## URL

```csharp
string baseUrl = "https://example.com";
```

---

## XPath

```csharp
string xpath = "//button[text()='Login']";
```

---

## CSS Selector

```csharp
string css = ".login-button";
```

---

## JSON

```csharp
string payload = """
{
    "username": "admin",
    "password": "password"
}
""";
```

---

## Windows Path

```csharp
string reportPath = @"C:\Reports\TestReport.html";
```

---

## Log Message

```csharp
Console.WriteLine($"Executing Test: {testName}");
```

---

# Best Practices (Modern C# 2026)

- ✅ Prefer string interpolation (`$`) over concatenation.
- ✅ Use raw string literals (`"""`) for JSON, XML, SQL and HTML.
- ✅ Use verbatim strings (`@`) for Windows file paths.
- ✅ Use `string.IsNullOrWhiteSpace()` when validating user input.
- ✅ Use `StringComparison.Ordinal` or `StringComparison.OrdinalIgnoreCase` for predictable string comparisons.

---

# Assignments

## Assignment 1 – Creating Strings

Create variables for:

- Your Name
- City
- Country
- Favourite Programming Language

Print them.

---

## Assignment 2 – Escape Sequences

Practice using:

- `\n`
- `\t`
- `\"`
- `\\`

Display the output.

---

## Assignment 3 – Verbatim Strings

Store a Windows file path using:

- Normal string
- Verbatim string (`@`)

Print both.

---

## Assignment 4 – Raw String Literals

Create a JSON object using a raw string literal (`"""`).

Print it.

---

## Assignment 5 – String Interpolation

Create variables:

- Name
- Age
- City

Print them using string interpolation.

---

## Assignment 6 – String Concatenation

Create:

```text
First Name
Last Name
```

Combine them into a full name using:

- `+`
- `string.Concat()`
- `string.Join()`

---

## Assignment 7 – Length

Create different strings.

Print their lengths using `.Length`.

---

## Assignment 8 – Indexing

Print:

- First character
- Middle character
- Last character

using indexing.

---

## Assignment 9 – Common String Methods

Practice:

- `ToUpper()`
- `ToLower()`
- `Trim()`
- `Contains()`
- `StartsWith()`
- `EndsWith()`
- `Replace()`
- `Substring()`
- `Split()`
- `IndexOf()`

---

## Assignment 10 – String Comparison

Compare strings using:

- `==`
- `Equals()`
- `StringComparison.Ordinal`
- `StringComparison.OrdinalIgnoreCase`

Observe the differences.

---

# 📘 Module 6 – Strings (Part 2: String Methods) *(Modern C# 2026)*

---

# 12. Common String Methods

## What are String Methods?

A **method** is an action that can be performed on an object.

Since a `string` is an object in C#, it comes with many built-in methods that help us manipulate text.

For example:

- Convert text to uppercase.
- Convert text to lowercase.
- Remove spaces.
- Search for text.
- Replace text.
- Split text.
- Extract part of a string.
- Check whether text exists.

Instead of writing complicated logic ourselves, we can use these built-in methods.

---

# 12.1 ToUpper()

Converts all letters to uppercase.

```csharp
string name = "Lokesh";

Console.WriteLine(name.ToUpper());
```

Output

```
LOKESH
```

Original string remains unchanged.

```csharp
Console.WriteLine(name);
```

Output

```
Lokesh
```

---

# 12.2 ToLower()

Converts all letters to lowercase.

```csharp
string name = "Lokesh";

Console.WriteLine(name.ToLower());
```

Output

```
lokesh
```

Useful when comparing user input.

---

# 12.3 Trim()

Removes spaces from both ends of a string.

```csharp
string name = "   Lokesh   ";

Console.WriteLine(name.Trim());
```

Output

```
Lokesh
```

Notice that spaces inside the string are not removed.

```csharp
string name = "Lokesh Reddy";

Console.WriteLine(name.Trim());
```

Output

```
Lokesh Reddy
```

---

# 12.4 TrimStart()

Removes spaces only from the beginning.

```csharp
string name = "   Lokesh";

Console.WriteLine(name.TrimStart());
```

Output

```
Lokesh
```

---

# 12.5 TrimEnd()

Removes spaces only from the end.

```csharp
string name = "Lokesh   ";

Console.WriteLine(name.TrimEnd());
```

Output

```
Lokesh
```

---

# 12.6 Contains()

Checks whether a string contains another string.

Returns a `bool`.

```csharp
string sentence = "I love C#";

Console.WriteLine(sentence.Contains("C#"));
```

Output

```
True
```

Another example

```csharp
Console.WriteLine(sentence.Contains("Java"));
```

Output

```
False
```

Very common in automation testing.

---

# 12.7 StartsWith()

Checks whether the string begins with a specific value.

```csharp
string file = "Report.pdf";

Console.WriteLine(file.StartsWith("Report"));
```

Output

```
True
```

---

# 12.8 EndsWith()

Checks whether the string ends with a specific value.

```csharp
string file = "Report.pdf";

Console.WriteLine(file.EndsWith(".pdf"));
```

Output

```
True
```

Commonly used for checking file extensions.

---

# 12.9 Replace()

Replaces one piece of text with another.

```csharp
string sentence = "I love Java";

string updated = sentence.Replace("Java", "C#");

Console.WriteLine(updated);
```

Output

```
I love C#
```

The original string is unchanged.

---

# 12.10 Substring()

Extracts part of a string.

```csharp
string word = "Automation";

Console.WriteLine(word.Substring(0, 4));
```

Output

```
Auto
```

Explanation

Start at index `0`.

Take `4` characters.

Another example

```csharp
Console.WriteLine(word.Substring(4));
```

Output

```
mation
```

---

# 12.11 Split()

Splits a string into multiple parts.

```csharp
string fruits = "Apple,Banana,Mango";

string[] items = fruits.Split(',');

Console.WriteLine(items[0]);
Console.WriteLine(items[1]);
Console.WriteLine(items[2]);
```

Output

```
Apple
Banana
Mango
```

We'll learn arrays next, so don't worry about `string[]` yet.

For now, understand that `Split()` breaks one string into many pieces.

---

# 12.12 IndexOf()

Returns the index of the first occurrence.

```csharp
string word = "Automation";

Console.WriteLine(word.IndexOf('m'));
```

Output

```
4
```

If not found

```csharp
Console.WriteLine(word.IndexOf('z'));
```

Output

```
-1
```

A return value of **-1** means the character or text was not found.

---

# 12.13 LastIndexOf()

Returns the last occurrence.

```csharp
string word = "Programming";

Console.WriteLine(word.LastIndexOf('m'));
```

Output

```
10
```

Useful when a character appears multiple times.

---

# 12.14 Insert()

Inserts text at a specified position.

```csharp
string word = "Lokesh";

string result = word.Insert(6, " Reddy");

Console.WriteLine(result);
```

Output

```
Lokesh Reddy
```

---

# 12.15 Remove()

Removes characters.

```csharp
string word = "Lokesh Reddy";

Console.WriteLine(word.Remove(6));
```

Output

```
Lokesh
```

Another example

```csharp
Console.WriteLine(word.Remove(6, 6));
```

Output

```
Lokesh
```

---

# 12.16 PadLeft()

Adds characters to the left.

```csharp
string number = "25";

Console.WriteLine(number.PadLeft(5, '0'));
```

Output

```
00025
```

---

# 12.17 PadRight()

Adds characters to the right.

```csharp
string word = "C#";

Console.WriteLine(word.PadRight(6, '*'));
```

Output

```
C#****
```

---

# 12.18 string.IsNullOrEmpty()

Checks whether a string is either:

- `null`
- Empty (`""`)

```csharp
string text = "";

Console.WriteLine(string.IsNullOrEmpty(text));
```

Output

```
True
```

---

# 12.19 string.IsNullOrWhiteSpace()

Checks whether a string is:

- null
- empty
- only spaces

```csharp
string text = "     ";

Console.WriteLine(string.IsNullOrWhiteSpace(text));
```

Output

```
True
```

Difference

```csharp
string text = "   ";

Console.WriteLine(string.IsNullOrEmpty(text));
Console.WriteLine(string.IsNullOrWhiteSpace(text));
```

Output

```
False
True
```

`IsNullOrWhiteSpace()` is generally preferred for validating user input.

---

# Best Practices

✔ Prefer `ToUpper()` and `ToLower()` only when you need to display text in a different case.

✔ Use `Trim()` before validating user input.

✔ Use `Contains()` for searching text.

✔ Use `StartsWith()` and `EndsWith()` for checking prefixes and suffixes.

✔ Use `Replace()` instead of manually rebuilding strings.

✔ Always check the result of `IndexOf()` before using it.

✔ Use `IsNullOrWhiteSpace()` instead of `IsNullOrEmpty()` for user input validation.

---

| Method                     | Think of it as...            | Parameters     |
| -------------------------- | ---------------------------- | -------------- |
| `Substring(start, length)` | Start here, take this many   | Index + Length |
| `Remove(start, count)`     | Start here, remove this many | Index + Count  |
| `Insert(index, text)`      | Insert before this position  | Index          |
| `IndexOf(value)`           | Find where this is           | Returns Index  |
| `LastIndexOf(value)`       | Find the last occurrence     | Returns Index  |
| `PadLeft(totalWidth)`      | Make the string this wide    | Final Length   |
| `PadRight(totalWidth)`     | Make the string this wide    | Final Length   |

Where? → Index
How many? → Length (or Count)

---

# Interview Questions

## Q1. Are strings mutable in C#?

No.

Strings are **immutable**.

Every method like `Replace()`, `Trim()`, or `ToUpper()` returns a **new string**.

The original string remains unchanged.

---

## Q2. What is the difference between `Trim()` and `Replace()`?

`Trim()` removes whitespace from the beginning and/or end of a string.

`Replace()` replaces one piece of text with another anywhere in the string.

---

## Q3. What does `IndexOf()` return if the value is not found?

It returns:

```
-1
```

---

## Q4. Which method is preferred for validating user input?

```
string.IsNullOrWhiteSpace()
```

because it handles:

- null
- empty strings
- strings containing only whitespace

---

# Assignments

## Assignment 1 – Case Conversion

Create a string containing your full name.

Print:

- Original
- Uppercase
- Lowercase

---

## Assignment 2 – Remove Spaces

Create a string with extra spaces before and after your name.

Use:

- `Trim()`
- `TrimStart()`
- `TrimEnd()`

Print the results.

---

## Assignment 3 – Search Text

Create a sentence.

Use:

- `Contains()`
- `StartsWith()`
- `EndsWith()`

Print the returned values.

---

## Assignment 4 – Replace Text

Create the sentence:

```
I love Java.
```

Replace `"Java"` with `"C#"`.

Print both the original and updated strings.

---

## Assignment 5 – Extract Text

Create:

```text
AutomationTesting
```

Use:

- `Substring()`
- `IndexOf()`
- `LastIndexOf()`

Print the results.

---

## Assignment 6 – Split Text

Split the following string:

```text
Apple,Banana,Mango,Orange
```

Print each fruit separately.

*(You'll revisit this assignment after learning arrays and loops.)*

---

## Assignment 7 – Insert and Remove

Start with:

```
Lokesh
```

Use:

- `Insert()`
- `Remove()`

Create and print modified versions.

---

## Assignment 8 – Padding

Create the number:

```
25
```

Display it as:

```
00025
```

using `PadLeft()`.

Also pad a short word on the right using `PadRight()`.

---

## Assignment 9 – Validate Input

Create three strings:

- `null`
- `""`
- `"     "`

Check them using:

- `string.IsNullOrEmpty()`
- `string.IsNullOrWhiteSpace()`

Observe the difference.

---

# Next Lesson

We'll learn **String Comparison**, including:

- `==`
- `Equals()`
- `StringComparison.Ordinal`
- `StringComparison.OrdinalIgnoreCase`

These are important for writing reliable and predictable comparisons in modern C# applications.

---

# String Comparison (Modern C# 2026)

## 1. What is String Comparison?

String comparison means checking whether two strings are the same or different.

Examples:

- Is the entered username correct?
- Is the entered password correct?
- Is the searched product name available?
- Does the entered email already exist?

Almost every real-world application compares strings.

---

# 2. Using `==`

The simplest way to compare two strings is with the equality operator.

```csharp
string firstName = "Lokesh";
string secondName = "Lokesh";

Console.WriteLine(firstName == secondName);
```

**Output**

```
True
```

If the values are different:

```csharp
string firstName = "Lokesh";
string secondName = "Reddy";

Console.WriteLine(firstName == secondName);
```

**Output**

```
False
```

---

# 3. Case Sensitivity

String comparison is **case-sensitive** by default.

```csharp
string firstName = "Lokesh";
string secondName = "lokesh";

Console.WriteLine(firstName == secondName);
```

**Output**

```
False
```

Although they look similar, the uppercase **L** and lowercase **l** are different characters.

---

# 4. Using `Equals()`

Another common way is the `Equals()` method.

```csharp
string firstName = "Lokesh";
string secondName = "Lokesh";

Console.WriteLine(firstName.Equals(secondName));
```

**Output**

```
True
```

Different values:

```csharp
string firstName = "Lokesh";
string secondName = "Reddy";

Console.WriteLine(firstName.Equals(secondName));
```

**Output**

```
False
```

---

# 5. Why Does `Equals()` Exist?

For simple comparisons, both work.

```csharp
firstName == secondName;
```

and

```csharp
firstName.Equals(secondName);
```

usually produce the same result.

However, `Equals()` provides additional options, such as choosing how strings should be compared.

This makes it more flexible for real-world applications.

---

# 6. Case-Insensitive Comparison

Often, you don't want uppercase and lowercase letters to matter.

Example:

User enters

```
lokesh
```

Database stores

```
Lokesh
```

These should be treated as equal.

Modern C# provides:

```csharp
string firstName = "Lokesh";
string secondName = "lokesh";

bool result = firstName.Equals(
    secondName,
    StringComparison.OrdinalIgnoreCase);

Console.WriteLine(result);
```

**Output**

```
True
```

---

# 7. `StringComparison.Ordinal`

```csharp
string firstName = "Lokesh";
string secondName = "Lokesh";

Console.WriteLine(
    firstName.Equals(
        secondName,
        StringComparison.Ordinal));
```

**Output**

```
True
```

### What does `Ordinal` mean?

It compares the Unicode value of each character exactly as it appears.

That means:

```
A ≠ a
```

Uppercase and lowercase are considered different.

It is:

- Fast
- Predictable
- Culture-independent

For identifiers, file names, API keys, and internal program values, this is usually the preferred comparison.

---

# 8. `StringComparison.OrdinalIgnoreCase`

Sometimes case should be ignored.

```csharp
string firstName = "Lokesh";
string secondName = "lokesh";

Console.WriteLine(
    firstName.Equals(
        secondName,
        StringComparison.OrdinalIgnoreCase));
```

**Output**

```
True
```

This compares characters exactly while ignoring differences in letter casing.

```
A = a
B = b
Z = z
```

This is commonly used for:

- Usernames
- Email addresses
- Search boxes
- Login forms
- Commands entered by users

---

# 9. Which One Should You Use?

| Method | Case Sensitive | Recommended |
|---------|----------------|-------------|
| `==` | Yes | Good for simple comparisons |
| `Equals()` | Yes | Good |
| `Equals(..., StringComparison.Ordinal)` | Yes | ✅ Preferred for exact comparisons |
| `Equals(..., StringComparison.OrdinalIgnoreCase)` | No | ✅ Preferred when case should be ignored |

---

# 10. Best Practices

✔ Use `==` for simple examples while learning.

✔ Prefer `Equals()` with `StringComparison` in production code.

✔ Use `Ordinal` for exact matches.

✔ Use `OrdinalIgnoreCase` when user input should ignore letter casing.

✔ Avoid converting strings with `ToUpper()` or `ToLower()` just for comparison. `StringComparison.OrdinalIgnoreCase` is clearer and more efficient.

Instead of:

```csharp
if (name.ToLower() == input.ToLower())
```

Prefer:

```csharp
if (name.Equals(input, StringComparison.OrdinalIgnoreCase))
```

---

# 11. Common Beginner Mistakes

### Mistake 1

```csharp
"Lokesh" == "lokesh"
```

Expecting

```
True
```

Actual Output

```
False
```

Because string comparison is case-sensitive by default.

---

### Mistake 2

```csharp
name.ToLower() == input.ToLower()
```

It works, but it's not the preferred modern approach.

Use:

```csharp
name.Equals(input, StringComparison.OrdinalIgnoreCase)
```

---

### Mistake 3

Assuming all comparisons should ignore case.

Sometimes case matters.

Example:

```
Password
```

should **not** match

```
password
```

unless the application specifically allows it.

---

# 12. Real-World Examples

### Login Username

```csharp
string storedUser = "Lokesh";
string enteredUser = "lokesh";

bool valid = storedUser.Equals(
    enteredUser,
    StringComparison.OrdinalIgnoreCase);

Console.WriteLine(valid);
```

**Output**

```
True
```

---

### Password Validation

```csharp
string storedPassword = "MyPassword123";
string enteredPassword = "mypassword123";

bool valid = storedPassword.Equals(
    enteredPassword,
    StringComparison.Ordinal);

Console.WriteLine(valid);
```

**Output**

```
False
```

Passwords are usually case-sensitive.

---

### Search Feature

```csharp
string product = "Laptop";

Console.WriteLine(
    product.Equals(
        "laptop",
        StringComparison.OrdinalIgnoreCase));
```

**Output**

```
True
```

---

# Interview Questions

## Q1. What is string comparison?

**Answer:**

String comparison is the process of checking whether two strings have the same value.

---

## Q2. Is `==` case-sensitive?

**Answer:**

Yes. By default, `==` performs a case-sensitive comparison.

---

## Q3. What is the difference between `Ordinal` and `OrdinalIgnoreCase`?

**Answer:**

- `Ordinal` compares strings exactly, including letter casing.
- `OrdinalIgnoreCase` compares strings exactly but ignores differences in uppercase and lowercase letters.

---

## Q4. Which comparison is recommended in modern C#?

**Answer:**

Use:

```csharp
string.Equals(otherString, StringComparison.Ordinal)
```

or

```csharp
string.Equals(otherString, StringComparison.OrdinalIgnoreCase)
```

depending on whether case sensitivity is required.

---

# Assignments

## Assignment 1 – Compare Using `==`

Create two strings with the same value and compare them using `==`.

Print the result.

---

## Assignment 2 – Compare Using `Equals()`

Compare two strings using the `Equals()` method.

Print the result.

---

## Assignment 3 – Case-Sensitive Comparison

Compare:

```text
Lokesh
lokesh
```

using:

- `==`
- `Equals()`

Observe the output.

---

## Assignment 4 – Case-Insensitive Comparison

Compare:

```text
Lokesh
lokesh
```

using:

```csharp
StringComparison.OrdinalIgnoreCase
```

Print the result.

---

## Assignment 5 – Username Validation

Create:

```csharp
string storedUsername = "Lokesh";
```

Read a username from the user using `Console.ReadLine()`.

Check whether it matches the stored username, ignoring case.

Print:

```
Login Successful
```

or

```
Invalid Username
```

---

# Automation Testing Connection

You'll use string comparison constantly in automation testing:

- Validating page titles.
- Checking button text.
- Verifying error messages.
- Comparing URLs.
- Validating usernames and emails.
- Checking API responses.
- Verifying table values.

Using `StringComparison.Ordinal` or `StringComparison.OrdinalIgnoreCase` makes these comparisons reliable and avoids unexpected behaviour caused by culture or letter casing.

---

# Next Module

📘 **Module 7 – Decision Making**

We'll learn:

- `if`
- `if-else`
- `else-if`
- Nested `if`
- `switch`
- Modern `switch` expressions ⭐
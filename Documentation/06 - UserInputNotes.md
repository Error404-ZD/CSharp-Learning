# 📘 Module 5 – User Input (Modern C# 2026)

## 1. What is User Input?

Until now, every value in our programs was hardcoded.

Example:

```csharp
string name = "Lokesh";
int age = 25;
```

Every time the program runs, the values remain the same.

Real-world applications don't work this way.

Users enter their own information such as:

- Name
- Age
- Email
- Password
- Phone Number
- Salary

A program must be able to read these values while it is running.

This process is called **User Input**.

---

## 2. Console.ReadLine()

`Console.ReadLine()` reads one line of text entered by the user.

It always returns a **string**.

### Syntax

```csharp
string input = Console.ReadLine();
```

### Example

```csharp
Console.Write("Enter your name: ");

string name = Console.ReadLine();

Console.WriteLine($"Hello {name}");
```

### Sample Output

```
Enter your name:
Lokesh

Hello Lokesh
```

---

## 3. Reading Numbers

Since `Console.ReadLine()` always returns a string, numbers must be converted.

### Example

```csharp
Console.Write("Enter your age: ");

int age = int.Parse(Console.ReadLine());

Console.WriteLine($"Age : {age}");
```

### Output

```
Enter your age:
24

Age : 24
```

---

## 4. Reading Decimal Numbers

```csharp
Console.Write("Enter your salary: ");

double salary = double.Parse(Console.ReadLine());

Console.WriteLine($"Salary : {salary}");
```

---

## 5. Reading Characters

There is no `Console.ReadChar()` method.

Instead, read a string and take the first character.

```csharp
Console.Write("Enter Grade: ");

char grade = Console.ReadLine()[0];

Console.WriteLine($"Grade : {grade}");
```

### Input

```
A
```

### Output

```
Grade : A
```

---

## 6. Reading Booleans

```csharp
Console.Write("Are you a student? (true/false): ");

bool isStudent = bool.Parse(Console.ReadLine());

Console.WriteLine(isStudent);
```

### Input

```
true
```

Output

```
True
```

---

# 7. Input Validation

Users don't always enter valid data.

Example

Program asks

```
Enter Age:
```

User enters

```
Twenty Five
```

Using

```csharp
int.Parse()
```

causes an exception.

```
System.FormatException
```

The program crashes.

A professional application should never crash because of invalid user input.

---

# 8. TryParse()

`TryParse()` safely converts input without throwing an exception.

### Syntax

```csharp
bool success = int.TryParse(input, out int number);
```

If conversion succeeds

```
success = true
```

Otherwise

```
success = false
```

---

### Example

```csharp
Console.Write("Enter Age: ");

string input = Console.ReadLine();

bool success = int.TryParse(input, out int age);

if (success)
{
    Console.WriteLine($"Age : {age}");
}
else
{
    Console.WriteLine("Invalid Age");
}
```

### Input

```
25
```

Output

```
Age : 25
```

### Input

```
Twenty Five
```

Output

```
Invalid Age
```

---

# 9. Why TryParse is Better than Parse

### Parse()

✔ Less code

❌ Crashes on invalid input

### TryParse()

✔ Safe

✔ No exception

✔ Used in production applications

✔ Recommended for user input

---

# 10. Parse vs Convert vs TryParse

| Method | Invalid Input | Returns |
|---------|---------------|----------|
| Parse() | Throws Exception | Converted Value |
| Convert.ToInt32() | Throws Exception (invalid format), returns 0 for `null` | Converted Value |
| TryParse() | No Exception | true / false |

---

# 11. Common Beginner Mistakes

## Mistake 1

```csharp
int age = Console.ReadLine();
```

❌ Wrong

`Console.ReadLine()` returns a string.

Correct

```csharp
int age = int.Parse(Console.ReadLine());
```

---

## Mistake 2

```csharp
char grade = Console.ReadLine();
```

❌ Wrong

Correct

```csharp
char grade = Console.ReadLine()[0];
```

---

## Mistake 3

Using Parse() for user input.

Prefer

```csharp
TryParse()
```

---

## Mistake 4

Ignoring the return value of TryParse.

Wrong

```csharp
int.TryParse(input, out int age);

Console.WriteLine(age);
```

Correct

```csharp
if (int.TryParse(input, out int age))
{
    Console.WriteLine(age);
}
else
{
    Console.WriteLine("Invalid Input");
}
```

---

# 12. Best Practices

✔ Always validate user input.

✔ Prefer `TryParse()` when reading numbers from users.

✔ Use meaningful prompts.

✔ Never assume the user enters correct data.

✔ Keep input and output separate for readability.

---

# 13. Real-World Examples

### Login

```
Username:
Password:
```

Uses

```csharp
Console.ReadLine()
```

---

### ATM

```
Enter Amount:
```

Uses

```csharp
decimal.TryParse()
```

---

### Banking

```
Transfer Amount:
```

Uses

```csharp
decimal.TryParse()
```

---

### Student Portal

```
Enter Roll Number:
```

Uses

```csharp
int.TryParse()
```

---

# Interview Questions

## Q1. What does Console.ReadLine() return?

**Answer:**

A string.

---

## Q2. Why can't we directly store Console.ReadLine() into an int?

Because it always returns a string, which must be converted.

---

## Q3. Which is safer for user input?

**Answer:**

`TryParse()`.

---

## Q4. What is the difference between Parse() and TryParse()?

- `Parse()` throws an exception for invalid input.
- `TryParse()` returns `true` or `false` without throwing an exception.

---

# Assignments

## Assignment 1 – Student Details

Read from the user:

- Name
- Age
- City

Print all details.

---

## Assignment 2 – Calculator Input

Read two integers.

Print:

- Sum
- Difference
- Product
- Division
- Modulus

---

## Assignment 3 – Employee Details

Read:

- Name
- Salary
- IsPermanent (true/false)

Print the details.

---

## Assignment 4 – Grade Input

Read a grade using `char`.

Display the grade.

---

## Assignment 5 – Input Validation

Ask the user to enter their age.

Use `TryParse()`.

If valid:

```
Welcome!
```

Otherwise:

```
Invalid age entered.
```

---

## Assignment 6 – Student Registration

Read the following:

- Name
- Age
- Percentage
- Grade
- IsPlaced

Use the correct data type for each field.

Display the complete student profile.

---

# Modern C# Notes (2026)

- `Console.ReadLine()` returns a nullable string (`string?`) when nullable reference types are enabled.
- Production code should handle possible `null` values before parsing.
- `TryParse()` remains the recommended approach for validating user input.
- Console applications are still widely used for learning, utilities, scripting, and automation, even though many modern applications use graphical or web interfaces.
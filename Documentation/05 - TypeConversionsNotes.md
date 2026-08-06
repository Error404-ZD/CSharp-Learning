# 📘 Type Conversion (Modern C# 2026)

---

# 1. What is Type Conversion?

Let's begin with a real-life example.

Imagine you have a bottle that holds **1 liter** of water.

Now suppose you want to pour that water into a **2-liter** bottle.

Easy.

Nothing is lost.

Now imagine the opposite.

You have **2 liters** of water and try to pour it into a **1-liter** bottle.

Some water will overflow.

Type conversion in C# works similarly.

Sometimes data fits perfectly into another type.

Sometimes information is lost.

---

## Definition

> **Type Conversion is the process of converting a value from one data type to another.**

Example:

```csharp
int age = 25;

double value = age;
```

The integer value becomes a double.

---

# 2. Why Do We Need Type Conversion?

Different variables store different types of data.

Suppose:

```csharp
int quantity = 5;

double price = 99.99;
```

Now calculate the total price.

```csharp
double total = quantity * price;
```

C# automatically converts `quantity` from `int` to `double`.

Without type conversion, this calculation wouldn't work correctly.

---

# 3. Types of Type Conversion

There are two main types.

| Type | Description |
|------|-------------|
| Implicit Conversion | Automatic conversion performed by the compiler |
| Explicit Conversion | Manual conversion performed by the programmer |

---

# 4. Implicit Conversion

Also called:

- Automatic Conversion
- Widening Conversion

The compiler automatically converts a smaller data type into a larger compatible type.

No data is lost.

Example:

```csharp
int number = 10;

double value = number;

Console.WriteLine(value);
```

Output

```text
10
```

The compiler automatically converts:

```text
int → double
```

---

## Why is this safe?

Memory comparison:

| Data Type | Size |
|-----------|------|
| int | 4 bytes |
| double | 8 bytes |

A larger container can easily hold a smaller value.

---

## More Examples

```csharp
byte number = 100;

int value = number;
```

```csharp
int age = 25;

long population = age;
```

```csharp
float height = 5.8f;

double newHeight = height;
```

---

# 5. Explicit Conversion (Casting)

Also called:

- Manual Conversion
- Narrowing Conversion

Sometimes you're converting a larger type into a smaller type.

The compiler cannot guarantee that data won't be lost.

So you must explicitly tell C#:

> "I understand the risk."

Example:

```csharp
double value = 10.8;

int number = (int)value;

Console.WriteLine(number);
```

Output

```text
10
```

Notice:

The decimal part is removed.

---

## Another Example

```csharp
double marks = 89.99;

int finalMarks = (int)marks;
```

Result

```text
89
```

No rounding occurs.

The decimal part is simply discarded.

---

# 6. Implicit vs Explicit Conversion

| Implicit | Explicit |
|-----------|----------|
| Automatic | Manual |
| Safe | May lose data |
| No casting required | Casting required |
| Smaller → Larger | Larger → Smaller |

Example:

```csharp
// Implicit
int age = 25;
double value = age;
```

```csharp
// Explicit
double salary = 55000.75;
int amount = (int)salary;
```

---

# 7. The Convert Class

Sometimes we need to convert values that aren't compatible through simple casting.

C# provides the `Convert` class.

---

## Convert.ToInt32()

```csharp
double number = 25.8;

int result = Convert.ToInt32(number);

Console.WriteLine(result);
```

Output

```text
26
```

Notice:

Unlike casting, `Convert.ToInt32()` rounds to the nearest integer.

---

## Casting vs Convert

```csharp
double value = 25.8;

int a = (int)value;

int b = Convert.ToInt32(value);
```

Output

```text
a = 25

b = 26
```

This is an important interview question.

---

## Convert.ToDouble()

```csharp
int age = 25;

double value = Convert.ToDouble(age);
```

---

## Convert.ToBoolean()

```csharp
string text = "True";

bool value = Convert.ToBoolean(text);
```

Output

```text
True
```

---

## Why Use Convert?

The `Convert` class is especially useful when reading user input or working with different data sources.

---

# 8. Parse()

`Parse()` converts a string into another data type.

Example:

```csharp
string age = "25";

int number = int.Parse(age);

Console.WriteLine(number);
```

Output

```text
25
```

---

## More Examples

```csharp
double.Parse("99.5");
```

```csharp
bool.Parse("true");
```

---

## Important

If the string cannot be converted, `Parse()` throws an exception.

Example:

```csharp
int.Parse("Lokesh");
```

Result

```text
FormatException
```

---

# 9. TryParse()

This is one of the most commonly used methods in real-world applications.

Instead of throwing an exception, it safely checks whether the conversion is possible.

Example:

```csharp
string input = "25";

bool success = int.TryParse(input, out int number);

Console.WriteLine(success);
Console.WriteLine(number);
```

Output

```text
True
25
```

---

## Invalid Input

```csharp
string input = "Lokesh";

bool success = int.TryParse(input, out int number);

Console.WriteLine(success);
Console.WriteLine(number);
```

Output

```text
False
0
```

No exception is thrown.

This makes `TryParse()` the preferred choice for user input.

---

# 10. Parse() vs TryParse()

| Parse() | TryParse() |
|----------|------------|
| Throws exception on invalid input | Returns `false` |
| Less safe | Safer |
| Used when input is guaranteed to be valid | Preferred for user input |

---

# 11. Overflow

Every numeric data type has a maximum value.

Example:

```csharp
byte number = 255;
```

Now increase it by one.

```csharp
number++;
```

Without overflow checking, the value wraps around.

Result:

```text
0
```

This is called **Overflow**.

---

# 12. checked

The `checked` keyword tells C# to detect overflow and throw an exception.

Example:

```csharp
checked
{
    byte number = 255;
    number++;
}
```

Output

```text
OverflowException
```

---

# 13. unchecked

The `unchecked` keyword tells C# to ignore overflow.

Example:

```csharp
unchecked
{
    byte number = 255;
    number++;
}
```

Output

```text
0
```

This is the default behavior for most arithmetic operations unless overflow checking is enabled.

---

# 14. Best Practices

- ✔ Prefer implicit conversion whenever possible.
- ✔ Use explicit casting only when you understand potential data loss.
- ✔ Use `Convert` when converting between common .NET types.
- ✔ Use `TryParse()` for user input.
- ✔ Avoid `Parse()` unless you're certain the input is valid.
- ✔ Use `checked` when overflow could produce incorrect results.

---

# 15. Common Beginner Mistakes

## Mistake 1

```csharp
double value = 10.8;

int number = value;
```

❌ Error

Correct:

```csharp
int number = (int)value;
```

---

## Mistake 2

```csharp
string age = "Twenty Five";

int.Parse(age);
```

❌ Throws `FormatException`

---

## Mistake 3

```csharp
int number = (int)25.8;
```

Expecting:

```text
26
```

Actually gets:

```text
25
```

Casting truncates the decimal part.

---

## Mistake 4

Using `Parse()` for user input without validation.

Prefer:

```csharp
int.TryParse()
```

---

# Assignments

## Assignment 1 – Implicit Conversion

Create variables using:

- byte → int
- int → long
- float → double

Print the converted values.

---

## Assignment 2 – Explicit Conversion

Convert:

- double → int
- long → short

Observe whether data is lost.

---

## Assignment 3 – Convert Class

Practice:

- `Convert.ToInt32()`
- `Convert.ToDouble()`
- `Convert.ToBoolean()`

Compare casting with `Convert.ToInt32()`.

---

## Assignment 4 – Parse()

Convert the following strings:

```text
"100"
"99.99"
"true"
```

into their appropriate data types.

---

## Assignment 5 – TryParse()

Ask the user to enter their age.

Use:

```csharp
int.TryParse()
```

If the input is valid, display the age.

Otherwise, display:

```text
Invalid age entered.
```

---

## Assignment 6 – Overflow

Demonstrate the difference between:

- `checked`
- `unchecked`

using a `byte` variable with the value `255`.

Observe the output.

---

# Automation Testing Connection

Type conversion is used constantly in Selenium and automation frameworks.

Examples:

- Converting text from web elements into numbers.
- Reading values from configuration files (`appsettings.json`).
- Validating numeric values displayed in the UI.
- Safely handling user input and test data using `TryParse()`.
- Converting strings from Excel, CSV, or JSON into appropriate C# data types.

Mastering type conversion will help you write reliable automation scripts that correctly process data from multiple sources.

---

# Next Chapter

# 📘 User Input

You'll learn:

- `Console.ReadLine()`
- Reading strings
- Reading numbers
- Reading characters
- Reading booleans
- Input validation
- Combining `Console.ReadLine()` with `TryParse()`

This is where your programs become interactive by accepting input from users.
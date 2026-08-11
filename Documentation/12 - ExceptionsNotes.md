# 📘 Module 11 – Exception Handling (Modern C# 2026)

---

# 1. Why Exception Handling Exists (Real-Life Analogy)

Before learning `try` and `catch`, let's understand **why exceptions exist**.

Imagine you're driving to work.

Everything is normal.

```
Start Car
↓

Drive
↓

Reach Office
```

Now imagine...

Halfway there...

```
🚗
↓

Tyre Puncture
```

Can you continue driving normally?

No.

Something unexpected happened.

That unexpected event interrupted the normal flow.

Programming has the exact same problem.

---

Example

```csharp
Console.Write("Enter Age : ");

int age = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Age Saved");
```

User enters

```
25
```

Everything works.

Now suppose the user enters

```
Twenty Five
```

What happens?

`Convert.ToInt32()` cannot convert

```
Twenty Five
```

into an integer.

The program crashes.

That crash is called an **Exception**.

---

## Definition

An **Exception** is an unexpected runtime error that interrupts the normal execution of a program.

Examples:

- Invalid user input
- File not found
- Divide by zero
- Network failure
- Database unavailable
- Null object
- Array index out of range

---

# Why not just use `if`?

You already know this.

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

Question:

Why do we still need Exceptions?

Because not every error can be checked beforehand.

Example

```csharp
File.ReadAllText("Data.txt");
```

How do you know whether

```
Data.txt
```

exists?

You don't.

Only when the program runs.

That's why Exceptions exist.

---

# 2. What is an Exception?

Think of your program like a straight road.

```
Start
↓

Input

↓

Calculation

↓

Save

↓

Finish
```

Everything goes perfectly.

Now imagine

```
Calculation

↓

Divide by Zero
```

Normal execution stops immediately.

The CLR (Common Language Runtime) creates an **Exception Object**.

That object contains information about the error.

---

# 3. What is the CLR?

You've heard me mention this before.

Remember:

```
Your C# Code

↓

.NET Runtime (CLR)

↓

Operating System
```

The CLR is responsible for:

- Running your C# program
- Managing memory
- Garbage Collection
- Security
- Exception Handling

When an exception occurs...

The CLR creates an Exception object.

---

# 4. try Block

A `try` block contains code that **might fail**.

Syntax

```csharp
try
{

}
```

Example

```csharp
try
{
    int number = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(number);
}
```

Nothing special yet.

We're simply telling C#

> "This code may throw an exception."

---

# 5. catch Block

If something inside `try` fails...

Control immediately jumps to `catch`.

Example

```csharp
try
{
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(age);
}
catch
{
    Console.WriteLine("Invalid Input");
}
```

Input

```
abc
```

Output

```
Invalid Input
```

Notice...

The application didn't crash.

---

Flow

```
try

↓

Exception?

↓

Yes

↓

catch

↓

Continue Program
```

---

# 6. Exception Object

`catch` can receive the Exception.

```csharp
catch(Exception ex)
{

}
```

Example

```csharp
try
{
    int age = Convert.ToInt32(Console.ReadLine());
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
```

Output

```
Input string was not in a correct format.
```

The Exception object contains useful information.

---

Common properties

```csharp
ex.Message
```

Human-readable error.

---

```csharp
ex.StackTrace
```

Where the error happened.

---

```csharp
ex.Source
```

Which assembly generated the exception.

---

```csharp
ex.GetType().Name
```

Returns the exception type.

Example

```
FormatException
```

---

# 7. Catching Specific Exceptions

Don't catch everything unless necessary.

Better:

```csharp
try
{
}
catch(FormatException)
{
}
```

Example

```csharp
try
{
    int age = Convert.ToInt32(Console.ReadLine());
}
catch(FormatException)
{
    Console.WriteLine("Please enter numbers only.");
}
```

Another

```csharp
try
{
    int answer = 10 / 0;
}
catch(DivideByZeroException)
{
    Console.WriteLine("Cannot divide by zero.");
}
```

---

# 8. Multiple catch Blocks

Different errors.

Different handling.

```csharp
try
{

}
catch(FormatException)
{

}
catch(DivideByZeroException)
{

}
catch(Exception)
{

}
```

Always keep the general

```csharp
Exception
```

last.

---

# 9. finally Block

Some code must execute whether an exception occurs or not.

That's what `finally` is for.

Example

```csharp
try
{
    Console.WriteLine("Opening File");
}
catch
{
    Console.WriteLine("Error");
}
finally
{
    Console.WriteLine("Closing File");
}
```

Output

```
Opening File

Closing File
```

Even if an exception happens,

`finally` still executes.

Real-world use:

- Close files
- Close database connections
- Release resources
- Clean up

---

# Flow Diagram

```
try

↓

Success?

↓

Yes

↓

finally

↓

End
```

or

```
try

↓

Exception

↓

catch

↓

finally

↓

End
```

---

# 10. throw

Sometimes **you** decide something is invalid.

Example

Age

```
-25
```

Technically,

it's an integer.

But logically,

it's invalid.

You can create an exception.

```csharp
if(age < 0)
{
    throw new Exception("Age cannot be negative.");
}
```

Now the CLR treats it like any other exception.

---

# 11. Common Built-in Exceptions

You'll encounter these often.

### FormatException

Wrong format.

```csharp
Convert.ToInt32("abc");
```

---

### DivideByZeroException

```csharp
10 / 0;
```

---

### OverflowException

Number too large.

```csharp
Convert.ToByte(500);
```

---

### NullReferenceException

Trying to use an object that is `null`.

```csharp
string name = null;

Console.WriteLine(name.Length);
```

---

### IndexOutOfRangeException

```csharp
int[] numbers = {1,2,3};

Console.WriteLine(numbers[10]);
```

---

### FileNotFoundException

Trying to read a file that doesn't exist.

---

# 12. Exception Handling vs TryParse

This is important.

Suppose you want an integer.

Option 1

```csharp
try
{
    int age = Convert.ToInt32(input);
}
catch
{
}
```

Option 2

```csharp
int.TryParse(input, out int age);
```

Which is better?

For user input...

✅ `TryParse()`

Why?

Because invalid user input is expected.

Exceptions are expensive.

`TryParse()` avoids creating exceptions.

---

When should you use Exceptions?

When something **unexpected** happens.

Examples:

- File missing
- Network error
- Database unavailable
- Permission denied

---

# 13. Exception Handling in Automation Testing

Real examples you'll encounter later:

- Browser failed to launch
- Element not found
- Timeout while waiting
- File download failed
- Screenshot creation failed

Automation frameworks use Exception Handling extensively.

---

# 14. Best Practices

✅ Catch only the exceptions you can handle.

✅ Use `TryParse()` for user input.

✅ Keep `try` blocks as small as possible.

✅ Always clean up resources in `finally` (or use `using`, which we'll learn later).

❌ Don't use empty `catch` blocks.

```csharp
catch
{
}
```

This hides errors and makes debugging difficult.

❌ Don't catch `Exception` everywhere unless it's appropriate.

---

# 15. Common Beginner Mistakes

### ❌ Using Exceptions for normal validation

Wrong

```csharp
try
{
    int age = Convert.ToInt32(input);
}
catch
{
}
```

Better

```csharp
int.TryParse(input, out int age);
```

---

### ❌ Empty catch blocks

```csharp
catch
{
}
```

Never ignore exceptions silently.

---

### ❌ Catching `Exception` first

Wrong

```csharp
catch(Exception)
{

}
catch(FormatException)
{

}
```

Specific exceptions become unreachable.

Always catch specific exceptions before general ones.

---

# 16. Interview Questions

- What is an Exception?
- Difference between compile-time and runtime errors?
- Why use Exception Handling?
- Difference between `throw` and `try-catch`?
- Difference between `TryParse()` and `Convert.ToInt32()`?
- Why is `finally` important?
- What information does the Exception object contain?
- Why shouldn't you overuse Exceptions for validation?

---

# 17. Assignments

After this lesson, you'll build programs using:

- `try`
- `catch`
- `finally`
- `throw`
- Exception objects
- Multiple `catch` blocks
- `TryParse()` vs Exceptions

No custom exceptions yet—we'll cover those later after you have a solid understanding of the built-in exception mechanism.
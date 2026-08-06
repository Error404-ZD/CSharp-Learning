# 📘 Module 8 – Loops (Modern C# 2026)

# 1. What is a Loop?

Imagine your teacher asks you to write:

```
I will practice C#
```

100 times.

Without loops, you would have to write:

```csharp
Console.WriteLine("I will practice C#");
Console.WriteLine("I will practice C#");
Console.WriteLine("I will practice C#");
...
```

100 times.

That would be slow, repetitive, and difficult to maintain.

Instead, C# provides **loops**.

## Definition

A **loop** is a control structure that repeatedly executes a block of code until a specified condition becomes false.

---

# 2. Why Do We Need Loops?

Suppose you want to print numbers from **1 to 100**.

Without loops:

```csharp
Console.WriteLine(1);
Console.WriteLine(2);
Console.WriteLine(3);
...
Console.WriteLine(100);
```

That's impractical.

With a loop:

```csharp
for (int i = 1; i <= 100; i++)
{
    Console.WriteLine(i);
}
```

Much shorter.

Much easier to understand.

---

# 3. Types of Loops in C#

We'll learn six important loop concepts.

| Loop | Purpose |
|-------|----------|
| while | Repeat while a condition is true |
| do-while | Execute at least once before checking the condition |
| for | Repeat a known number of times |
| foreach | Iterate through collections |
| break | Exit a loop immediately |
| continue | Skip the current iteration and move to the next one |

---

# 4. while Loop

## Syntax

```csharp
while (condition)
{
    // Code
}
```

The condition is checked **before** each iteration.

If the condition is false initially, the loop never executes.

Example

```csharp
int number = 1;

while (number <= 5)
{
    Console.WriteLine(number);
    number++;
}
```

Output

```
1
2
3
4
5
```

---

# 5. How a while Loop Works

Imagine this flow.

```
Condition?

↓

True?

↓

Run Code

↓

Update Variable

↓

Go Back

↓

Condition?

↓

False?

↓

Exit Loop
```

If you forget to update the variable, the condition may never become false.

That creates an **infinite loop**.

Example

```csharp
int number = 1;

while (number <= 5)
{
    Console.WriteLine(number);
}
```

The value of `number` never changes.

The loop never ends.

---

# 6. do-while Loop

A `do-while` loop checks the condition **after** executing the code.

Syntax

```csharp
do
{
    // Code
}
while (condition);
```

Example

```csharp
int number = 1;

do
{
    Console.WriteLine(number);
    number++;
}
while (number <= 5);
```

Output

```
1
2
3
4
5
```

---

# 7. Difference Between while and do-while

### while

Checks first.

```
Condition

↓

True?

↓

Run
```

May execute **zero** times.

### do-while

Runs first.

```
Run

↓

Condition

↓

Repeat?
```

Always executes **at least once**.

Example

```csharp
int number = 10;

while (number <= 5)
{
    Console.WriteLine(number);
}
```

Output

```
(No output)
```

Now

```csharp
int number = 10;

do
{
    Console.WriteLine(number);
}
while (number <= 5);
```

Output

```
10
```

---

# 8. for Loop ⭐⭐⭐⭐⭐

The most commonly used loop in C#.

Syntax

```csharp
for (initialization; condition; update)
{
    // Code
}
```

Example

```csharp
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
```

Output

```
1
2
3
4
5
```

---

# 9. Understanding the for Loop

```csharp
for (int i = 1; i <= 5; i++)
```

Break it down.

### Initialization

```csharp
int i = 1;
```

Runs only once.

---

### Condition

```csharp
i <= 5
```

Checked before every iteration.

---

### Update

```csharp
i++
```

Runs after each iteration.

---

Flow

```
Initialization

↓

Condition

↓

Run Code

↓

Update

↓

Condition

↓

...
```

---

# 10. foreach Loop

Used to iterate through collections.

We'll fully understand this after learning **arrays** and **collections**.

For now, here's a preview.

```csharp
string[] fruits =
{
    "Apple",
    "Banana",
    "Orange"
};

foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

Output

```
Apple
Banana
Orange
```

We'll revisit this in Modules 10 and 14.

---

# 11. break

Stops the loop immediately.

Example

```csharp
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }

    Console.WriteLine(i);
}
```

Output

```
1
2
3
4
```

The loop exits when `i` becomes 5.

---

# 12. continue

Skips the current iteration and continues with the next one.

Example

```csharp
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        continue;
    }

    Console.WriteLine(i);
}
```

Output

```
1
2
4
5
```

Notice that 3 is skipped.

---

# 13. Nested Loops

A loop inside another loop.

Example

```csharp
for (int row = 1; row <= 3; row++)
{
    for (int column = 1; column <= 2; column++)
    {
        Console.WriteLine($"Row {row}, Column {column}");
    }
}
```

Output

```
Row 1, Column 1
Row 1, Column 2
Row 2, Column 1
Row 2, Column 2
Row 3, Column 1
Row 3, Column 2
```

Nested loops are commonly used for:

- Tables
- Patterns
- Matrices
- Game boards
- Spreadsheet-like data

---

# 14. Choosing the Right Loop

| Situation | Recommended Loop |
|-----------|------------------|
| Unknown number of repetitions | `while` |
| Execute at least once | `do-while` |
| Known number of repetitions | `for` |
| Iterating through arrays or collections | `foreach` |

---

# 15. Common Beginner Mistakes

### Mistake 1

Forgetting to update the loop variable.

```csharp
while (number <= 5)
{
    Console.WriteLine(number);
}
```

Infinite loop.

---

### Mistake 2

Using the wrong condition.

```csharp
for (int i = 1; i >= 5; i++)
```

The condition is false immediately.

The loop never runs.

---

### Mistake 3

Off-by-one errors.

```csharp
for (int i = 0; i <= 5; i++)
```

Produces:

```
0
1
2
3
4
5
```

That's six numbers, not five.

Always think carefully about:

- Starting value
- Ending condition

---

### Mistake 4

Changing the loop variable inside the loop unexpectedly.

```csharp
for (int i = 1; i <= 5; i++)
{
    i += 2;
}
```

This makes the loop difficult to understand.

---

# 16. Best Practices

✔ Use `for` when the number of iterations is known.

✔ Use `while` when the stopping condition is based on logic rather than a count.

✔ Use `foreach` when iterating through collections.

✔ Keep loop bodies small and readable.

✔ Avoid infinite loops unless intentionally required.

✔ Use `break` and `continue` only when they improve clarity.

---

# Assignments

## Assignment 1 – while Loop

Print numbers from **1 to 10** using a `while` loop.

---

## Assignment 2 – do-while Loop

Ask the user to enter a number.

Keep displaying it until they enter **0**.

Use a `do-while` loop.

---

## Assignment 3 – for Loop

Print:

```
10
9
8
...
1
```

using a `for` loop.

---

## Assignment 4 – Multiplication Table

Ask the user for a number.

Print its multiplication table from **1 to 10**.

Example

```
7 × 1 = 7
7 × 2 = 14
...
7 × 10 = 70
```

---

## Assignment 5 – break

Print numbers from **1 to 20**.

Stop the loop when the number becomes **13**.

---

## Assignment 6 – continue

Print numbers from **1 to 20**.

Skip all multiples of **3**.

---

## Assignment 7 – Nested Loops

Print the following pattern.

```
*
**
***
****
*****
```

---

## Assignment 8 – Reverse Pattern

Print

```
*****
****
***
**
*
```

---

# Automation Testing Connection

Loops are used constantly in automation testing.

Examples:

- Iterate through rows in a web table.
- Validate every item in a dropdown.
- Process search results.
- Check multiple test data records.
- Retry an operation until a condition is met.
- Read data from Excel or CSV files.
- Loop through collections of web elements returned by Selenium.

Understanding loops thoroughly now will make Selenium and Reqnroll automation much easier later.

---

# Next Chapter

📘 **Module 9 – Methods**

We'll learn:

- Why methods exist
- Parameters
- Arguments
- Return values
- `void`
- Method Overloading
- Optional Parameters
- Named Arguments
- Expression-bodied Methods ⭐
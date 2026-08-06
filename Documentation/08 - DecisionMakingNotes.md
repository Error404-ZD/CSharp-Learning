# Decision Making (Modern C# 2026)

# 1. What is Decision Making?

Until now, every program you've written has executed from top to bottom.

Example:

```csharp
Console.WriteLine("Hello");
Console.WriteLine("Welcome");
Console.WriteLine("Goodbye");
```

Output:

```
Hello
Welcome
Goodbye
```

The program has no choice—it executes every statement.

But real-world applications often need to make decisions.

Examples:

- Is the user old enough to vote?
- Is the username correct?
- Did the login succeed?
- Is the product in stock?
- Is the entered mark a pass or fail?

To make decisions, C# provides conditional statements.

---

# 2. The `if` Statement

The `if` statement executes a block of code only when a condition is `true`.

Syntax:

```csharp
if (condition)
{
    // Code executes if the condition is true
}
```

Example:

```csharp
int age = 20;

if (age >= 18)
{
    Console.WriteLine("Eligible to vote");
}
```

Output:

```
Eligible to vote
```

If the condition is false:

```csharp
int age = 15;

if (age >= 18)
{
    Console.WriteLine("Eligible to vote");
}
```

Output:

```
(No output)
```

The code inside the `if` block is skipped.

---

# 3. Boolean Expressions

The condition inside an `if` statement must evaluate to a `bool`.

Valid examples:

```csharp
age >= 18
marks >= 35
isLoggedIn
!isAdmin
```

Invalid:

```csharp
if (10)
```

This produces a compilation error because `10` is an `int`, not a `bool`.

---

# 4. The `if-else` Statement

Sometimes you want one action when the condition is true and another when it is false.

Syntax:

```csharp
if (condition)
{
    // True block
}
else
{
    // False block
}
```

Example:

```csharp
int marks = 80;

if (marks >= 35)
{
    Console.WriteLine("Pass");
}
else
{
    Console.WriteLine("Fail");
}
```

---

# 5. The `else-if` Ladder

When there are multiple possible conditions, use `else if`.

Example:

```csharp
int marks = 85;

if (marks >= 90)
{
    Console.WriteLine("Grade A");
}
else if (marks >= 75)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 50)
{
    Console.WriteLine("Grade C");
}
else
{
    Console.WriteLine("Fail");
}
```

Conditions are checked from top to bottom.

As soon as one condition is true, the remaining conditions are skipped.

---

# 6. Why Order Matters

Consider:

```csharp
int marks = 95;

if (marks >= 50)
{
    Console.WriteLine("Grade C");
}
else if (marks >= 75)
{
    Console.WriteLine("Grade B");
}
else if (marks >= 90)
{
    Console.WriteLine("Grade A");
}
```

Output:

```
Grade C
```

Although the student scored 95, the first condition (`marks >= 50`) is already true.

Always place the most specific conditions first.

Correct order:

```csharp
if (marks >= 90)
```

then

```csharp
else if (marks >= 75)
```

then

```csharp
else if (marks >= 50)
```

---

# 7. Nested `if`

An `if` statement can contain another `if` statement.

Example:

```csharp
int age = 22;
bool hasLicence = true;

if (age >= 18)
{
    if (hasLicence)
    {
        Console.WriteLine("You can drive.");
    }
}
```

Execution:

- Check age.
- If true, check licence.
- If both are true, print the message.

---

# 8. The `switch` Statement

When comparing one value against many possible values, `switch` is often clearer than multiple `else if` statements.

Example:

```csharp
int day = 3;

switch (day)
{
    case 1:
        Console.WriteLine("Monday");
        break;

    case 2:
        Console.WriteLine("Tuesday");
        break;

    case 3:
        Console.WriteLine("Wednesday");
        break;

    default:
        Console.WriteLine("Invalid day");
        break;
}
```

Output:

```
Wednesday
```

---

# 9. The `break` Statement

`break` ends the current `case`.

Without `break`, execution would continue into the next case, which is usually not what you want.

---

# 10. Modern Switch Expressions ⭐

Modern C# introduced switch expressions.

Instead of:

```csharp
switch (grade)
{
    case 'A':
        return "Excellent";

    case 'B':
        return "Good";

    default:
        return "Unknown";
}
```

You can write:

```csharp
string result = grade switch
{
    'A' => "Excellent",
    'B' => "Good",
    'C' => "Average",
    _ => "Unknown"
};
```

This syntax is shorter and is widely used in modern C# code.

We'll practise both styles.

---

# 11. Best Practices

✔ Keep conditions simple and readable.

✔ Use meaningful boolean variable names.

Example:

```csharp
bool isLoggedIn;
bool hasPermission;
bool isEligible;
```

✔ Put the most specific conditions first in an `else-if` ladder.

✔ Use `switch` when comparing one variable against many constant values.

✔ Learn both classic `switch` and modern `switch` expressions.

---

# 12. Common Beginner Mistakes

### Mistake 1

```csharp
if (age = 18)
```

Wrong.

`=` assigns a value.

Use:

```csharp
if (age == 18)
```

---

### Mistake 2

Writing conditions in the wrong order.

```csharp
if (marks >= 50)
```

before

```csharp
if (marks >= 90)
```

causes incorrect results.

---

### Mistake 3

Forgetting braces.

Even though braces may be optional for a single statement, always use them while learning.

---

# Interview Questions

## Q1. What is decision making?

Decision making allows a program to execute different blocks of code based on conditions.

---

## Q2. What data type must an `if` condition evaluate to?

`bool`

---

## Q3. What is the difference between `if-else` and `else-if`?

- `if-else` chooses between two paths.
- `else-if` allows multiple conditions to be checked.

---

## Q4. When should you use a `switch` statement?

When comparing a single variable against multiple constant values.

---

## Q5. What is a switch expression?

A modern, concise alternative to the traditional `switch` statement that returns a value.

---

# Assignments

## Assignment 1 – Simple `if`

Ask the user to enter their age.

If the age is 18 or above, print:

```
Eligible to vote
```

---

## Assignment 2 – `if-else`

Ask the user to enter marks.

If marks are 35 or above:

```
Pass
```

Otherwise:

```
Fail
```

---

## Assignment 3 – `else-if`

Print grades:

- 90+ → Grade A
- 75–89 → Grade B
- 50–74 → Grade C
- Below 50 → Fail

---

## Assignment 4 – Nested `if`

Check:

- Age ≥ 18
- Has Driving Licence

Print whether the person can legally drive.

---

## Assignment 5 – `switch`

Read a number from 1–7.

Print the corresponding weekday.

---

## Assignment 6 – Modern Switch Expression

Using a character grade (`A`, `B`, `C`, `D`), return an appropriate message using a switch expression.

---

# Automation Testing Connection

Decision making is one of the most frequently used concepts in automation testing.

Examples:

- Check if an element is displayed before clicking it.
- Validate whether login succeeded.
- Handle different browser types.
- Execute different steps based on the test environment.
- Decide whether a test should continue or fail.

Nearly every automation script uses `if`, `else`, or `switch` statements to control program flow.
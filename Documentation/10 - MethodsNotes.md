# 📘 Module 9 – Methods (Modern C# 2026)

---

# 1. What is a Method?

Before understanding methods, let's understand a real-life problem.

Imagine you have to make tea.

The steps are:

- Boil water
- Add tea powder
- Add sugar
- Add milk
- Pour into a cup

Now imagine your family asks for tea 5 times today.

Will you rewrite all five steps every time?

No.

You'll simply say:

> "Make Tea."

The entire set of steps is grouped into one task.

Programming works the same way.

Instead of writing the same code repeatedly, we group it into a **Method**.

---

# Definition

A **Method** is a reusable block of code that performs a specific task.

Think of it as giving a name to a sequence of instructions.

---

# Real-Life Examples

Method Name

```
MakeTea()
```

What it does

- Boils water
- Adds ingredients
- Serves tea

---

Method Name

```
WashClothes()
```

What it does

- Fill water
- Add detergent
- Wash
- Rinse
- Dry

---

Programming Example

Instead of writing

```csharp
Console.WriteLine("Hello");
Console.WriteLine("Welcome");
Console.WriteLine("Enjoy learning C#");
```

many times,

we create

```csharp
public static void DisplayWelcomeMessage()
{
    Console.WriteLine("Hello");
    Console.WriteLine("Welcome");
    Console.WriteLine("Enjoy learning C#");
}
```

Whenever needed

```csharp
DisplayWelcomeMessage();
```

The same code executes again.

---

# 2. Why Do Methods Exist?

Imagine your application prints a company logo.

Without methods

```csharp
Console.WriteLine("Company");
Console.WriteLine("Welcome");
Console.WriteLine("------------");
```

Suppose this appears in **50 different places**.

Now the company changes its logo.

You must update all 50 locations.

Instead

```csharp
DisplayCompanyLogo();
```

Update one method.

Everywhere automatically changes.

---

Methods make programs

- Reusable
- Easier to maintain
- Easier to read
- Easier to debug
- Less repetitive

---

# 3. Method Syntax

General syntax

```csharp
AccessModifier ReturnType MethodName()
{
    // Code
}
```

Example

```csharp
public static void DisplayMessage()
{
    Console.WriteLine("Hello");
}
```

Let's understand each part.

---

## public

Access Modifier

Controls who can use this method.

We'll learn access modifiers in detail during OOP.

For now, use

```csharp
public
```

---

## static

Means the method belongs to the class itself.

You already use

```csharp
Main()
```

as a static method.

We'll fully understand `static` in Module 12 (OOP).

For now, simply include it.

---

## void

Return Type

Means

"This method does not return any value."

Example

```csharp
public static void DisplayName()
{
    Console.WriteLine("Lokesh");
}
```

It prints something.

It does **not** give anything back.

---

## Method Name

Choose meaningful names.

Good

```csharp
DisplayStudentDetails()

CalculateSalary()

PrintInvoice()
```

Bad

```csharp
ABC()

Test()

Method1()
```

Microsoft naming convention:

Use **PascalCase**

Examples

```csharp
DisplayMarks()

CalculateArea()

PrintStudentProfile()
```

---

# 4. Calling a Method

Creating a method does nothing by itself.

You must call it.

Method

```csharp
public static void SayHello()
{
    Console.WriteLine("Hello");
}
```

Calling

```csharp
SayHello();
```

Output

```
Hello
```

---

# 5. Parameters

Sometimes methods need information.

Example

Without parameter

```csharp
DisplayName();
```

Always prints

```
Lokesh
```

What if we want different names?

We pass data.

```csharp
public static void DisplayName(string name)
{
    Console.WriteLine(name);
}
```

Here

```csharp
string name
```

is called a **Parameter**.

Definition

A **Parameter** is a variable declared in a method definition that receives data when the method is called.

---

# 6. Arguments

Calling

```csharp
DisplayName("Lokesh");
```

"Lokesh"

is an **Argument**.

Definition

An **Argument** is the actual value supplied to a method.

---

Parameter

```csharp
string name
```

Argument

```csharp
"Lokesh"
```

Another example

```csharp
DisplayAge(25);
```

Parameter

```csharp
int age
```

Argument

```csharp
25
```

---

# 7. Multiple Parameters

Methods can receive more than one value.

Example

```csharp
public static void DisplayStudent(string name, int age)
{
    Console.WriteLine($"{name} - {age}");
}
```

Calling

```csharp
DisplayStudent("Lokesh", 25);
```

Output

```
Lokesh - 25
```

---

# 8. Return Values

Some methods don't just perform work.

They give something back.

Example

```csharp
public static int AddNumbers(int a, int b)
{
    return a + b;
}
```

Calling

```csharp
int result = AddNumbers(10, 20);

Console.WriteLine(result);
```

Output

```
30
```

Notice

Instead of printing,

the method **returns** a value.

---

# 9. void vs Return

void

```csharp
public static void Display()
{
    Console.WriteLine("Hello");
}
```

Returns nothing.

---

Return value

```csharp
public static int Square(int number)
{
    return number * number;
}
```

Returns

```
number * number
```

---

# 10. Method Overloading

C# allows multiple methods with the same name.

As long as their parameters are different.

Example

```csharp
Display(int number)

Display(string name)

Display(double salary)
```

All three are valid.

The compiler selects the correct one.

Example

```csharp
public static void Display(int number)
{
    Console.WriteLine(number);
}

public static void Display(string text)
{
    Console.WriteLine(text);
}
```

Calling

```csharp
Display(25);

Display("Lokesh");
```

---

# 11. Optional Parameters

Sometimes a value is optional.

Example

```csharp
public static void Welcome(string name = "Guest")
{
    Console.WriteLine($"Welcome {name}");
}
```

Calling

```csharp
Welcome();
```

Output

```
Welcome Guest
```

Calling

```csharp
Welcome("Lokesh");
```

Output

```
Welcome Lokesh
```

---

# 12. Named Arguments

Normally

```csharp
DisplayStudent("Lokesh", 25);
```

Named arguments let you specify parameter names.

```csharp
DisplayStudent(age: 25, name: "Lokesh");
```

Order no longer matters.

This improves readability when methods have many parameters.

---

# 13. Expression-bodied Methods ⭐

Modern C# provides a shorter syntax for simple methods.

Traditional

```csharp
public static int Square(int number)
{
    return number * number;
}
```

Modern

```csharp
public static int Square(int number) => number * number;
```

Another example

```csharp
public static string GetName() => "Lokesh";
```

Use this only when the method contains a single expression.

---

# 14. Best Practices

✔ One method should perform one responsibility.

✔ Choose descriptive method names.

✔ Keep methods short whenever possible.

✔ Reuse methods instead of copying code.

✔ Use `return` when a value needs to be sent back.

✔ Use `void` when the method only performs an action.

---

# 15. Common Beginner Mistakes

### Mistake 1

Creating a method but never calling it.

```csharp
DisplayMessage();
```

must be called.

---

### Mistake 2

Confusing parameters with arguments.

Parameter

```csharp
string name
```

Argument

```csharp
"Lokesh"
```

---

### Mistake 3

Trying to store the result of a `void` method.

Wrong

```csharp
int result = DisplayMessage();
```

A `void` method returns nothing.

---

### Mistake 4

Forgetting the `return` statement.

Wrong

```csharp
public static int Add()
{
}
```

Correct

```csharp
public static int Add()
{
    return 10;
}
```

---

# 16. Interview Questions

### Q1. What is a method?

A method is a reusable block of code that performs a specific task.

---

### Q2. Why do we use methods?

To reduce code duplication, improve readability, and make programs easier to maintain.

---

### Q3. What is the difference between a parameter and an argument?

**Parameter:** Variable declared in the method definition.

**Argument:** Actual value passed when calling the method.

---

### Q4. What is the difference between `void` and `return`?

`void` methods return nothing.

Methods with a return type return a value using the `return` keyword.

---

### Q5. What is method overloading?

Having multiple methods with the same name but different parameter lists.

---

# Assignments

### Assignment 1

Create a method

```csharp
DisplayGreeting()
```

Print

```
Welcome to Modern C#
```

---

### Assignment 2

Create a method

```csharp
DisplayStudent()
```

Accept

- Name
- Age
- City

Print them.

---

### Assignment 3

Create

```csharp
AddNumbers()
```

Return the sum.

---

### Assignment 4

Create

```csharp
FindSquare()
```

Return the square of a number.

---

### Assignment 5

Create overloaded methods

```csharp
Display(int)

Display(double)

Display(string)
```

Call all three.

---

### Assignment 6

Create

```csharp
Welcome(string name = "Guest")
```

Call it

- without an argument
- with your name

---

### Assignment 7

Create a method with three parameters.

Call it using **named arguments**.

---

### Assignment 8

Convert a simple method into an **expression-bodied method**.

Example

```csharp
GetCountry()
```

Return

```
India
```

---

# Next Chapter

📘 Module 10 – Arrays

You'll learn how to store multiple values of the same type efficiently and finally understand why `foreach` exists.
# 📘 Variables (Modern C# 2026)

---

# 1. What is a Variable?

Before understanding a variable, let's understand a real-life problem.

Imagine your teacher asks you to remember these numbers:

- 25
- 100
- 4500
- 987654321

Can you remember all of them forever?

Probably not.

Instead, you write them in a notebook.

That notebook stores the information so you can use it later.

A computer has the same problem.

It also needs a place to temporarily store information while a program is running.

That place is called a **Variable**.

---

## Definition

> **A variable is a named memory location used to store data temporarily while a program is executing.**

Let's simplify that.

**Variable = Named Box**

Imagine this box:

```text
+----------------+
|       25       |
+----------------+
```

Now give the box a name.

**Age**

```text
Age

+----------------+
|       25       |
+----------------+
```

Now instead of saying:

> "Give me the box that contains 25."

You simply say:

> "Give me Age."

That's exactly what variables do.

---

## Real-Life Example

Suppose you're filling an online registration form.

It asks for:

- Name
- Age
- Email
- Phone

Your information:

| Field | Value |
|--------|-------|
| Name | Lokesh |
| Age | 24 |
| Email | abc@gmail.com |
| Phone | 9876543210 |

Inside the program, these become variables.

```csharp
string name = "Lokesh";
int age = 24;
string email = "abc@gmail.com";
string phone = "9876543210";
```

Each variable stores one piece of information.

---

# 2. Why are Variables Needed?

Without variables, programs would be impossible to write.

Imagine this program.

```csharp
Console.WriteLine(25);
```

Output:

```text
25
```

Now suppose the user's age changes to **26**.

You must edit the code.

```csharp
Console.WriteLine(26);
```

Now imagine the age is used in **500 places**.

You would have to change all 500 numbers.

Instead, store it once.

```csharp
int age = 25;

Console.WriteLine(age);
```

Next year:

```csharp
age = 26;
```

Done.

Everything automatically uses the new value.

---

Variables make programs:

- Flexible
- Reusable
- Easy to Maintain

---

## Another Example

Imagine an ATM.

Every customer has a different balance.

Without variables:

```text
Balance = 5000
```

Everyone would see ₹5000.

Impossible.

Instead:

```text
Customer A

Balance = 5000

Customer B

Balance = 85000

Customer C

Balance = 1200
```

Each customer gets their own value stored in variables.

---

# 3. Variable Declaration

Before storing something, C# needs to know:

> "What kind of data will this variable store?"

This is called **Declaration**.

## Syntax

```csharp
DataType variableName;
```

Example:

```csharp
int age;
```

### Breakdown

`int`

Means:

> "I will store whole numbers."

`age`

Variable name.

`;`

End of statement.

Every C# statement ends with a semicolon (`;`).

---

### Memory Representation

```text
Age

+---------+
| Empty   |
+---------+
```

The box exists.

Nothing is stored yet.

---

### More Examples

```csharp
string name;

double salary;

bool isAdmin;

char grade;
```

Notice:

Nothing has values yet.

Only boxes are created.

---

# 4. Variable Initialization

Declaration creates the box.

Initialization puts something inside it.

Example:

```csharp
int age;

age = 24;
```

Memory:

```text
Age

+--------+
|   24   |
+--------+
```

Usually we do both together.

```csharp
int age = 24;
```

This is called:

> **Declaration + Initialization**

It is the most common way.

---

### More Examples

```csharp
string name = "Lokesh";

bool isStudent = true;

double salary = 55000.75;

char grade = 'A';
```

---

# 5. Variable Naming Rules

This is where many beginners make mistakes.

---

## Rule 1

Cannot start with a number.

❌ Wrong

```csharp
int 1age = 25;
```

✅ Correct

```csharp
int age1 = 25;
```

---

## Rule 2

Cannot contain spaces.

❌ Wrong

```csharp
int my age;
```

✅ Correct

```csharp
int myAge;
```

---

## Rule 3

Cannot use C# keywords.

❌ Wrong

```csharp
int int;
```

`int` is already a keyword.

---

## Rule 4

Variable names may contain:

- Letters
- Numbers
- `_` (underscore)

---

# Naming Convention (Microsoft Standard)

Modern C# uses **camelCase** for local variables.

Examples:

```csharp
string firstName;

string lastName;

double accountBalance;

bool isLoggedIn;
```

Notice:

- First word starts with lowercase.
- Every new word starts with uppercase.

This is called **camelCase**.

---

## Bad Variable Names

```csharp
int x;

int a;

int temp;

int xyz;
```

Can you guess what they store?

No.

---

## Good Variable Names

```csharp
int employeeAge;

double monthlySalary;

string customerName;

bool isAdmin;
```

Now anyone can understand the code.

---

# 6. Can Variables Change?

Yes.

That's why they're called **Variables**.

Example:

```csharp
int marks = 50;

marks = 70;

marks = 90;
```

Final value:

```text
90
```

Each new assignment replaces the previous value.

---

### Memory Representation

Initially:

```text
Marks

+------+
|  50  |
+------+
```

Later:

```text
Marks

+------+
|  70  |
+------+
```

Later:

```text
Marks

+------+
|  90  |
+------+
```

Only **one value** exists at a time.

---

# 7. Declaration vs Initialization

## Declaration

```csharp
int age;
```

Box created.

No value.

---

## Initialization

```csharp
age = 25;
```

Value stored.

---

## Combined

```csharp
int age = 25;
```

This is the most commonly used approach.

---

# 8. Common Beginner Mistakes

## Mistake 1

Using a variable before assigning a value.

```csharp
int age;

Console.WriteLine(age);
```

❌ Error:

> Local variables must be assigned before use.

---

## Mistake 2

Giving unclear names.

❌

```csharp
int x;
```

✅ Better

```csharp
int studentAge;
```

---

## Mistake 3

Changing the meaning of a variable.

```csharp
int age = 25;

age = 100000;
```

Now the variable no longer represents an age.

Always choose names that match the data they store.

---

# 9. Variable Scope (Preview)

We'll learn scope in detail later.

For now:

> A variable is only accessible inside the block where it is declared.

Example:

```csharp
{
    int age = 25;
    Console.WriteLine(age); // Works
}

// Console.WriteLine(age); // Error
```

We'll revisit this topic when learning **methods** and **code blocks**.

---

# Interview Questions

## Q1. What is a variable?

**Answer:**

A variable is a named memory location used to store data temporarily during program execution.

---

## Q2. What is variable declaration?

Creating a variable by specifying its data type and name.

Example:

```csharp
int age;
```

---

## Q3. What is variable initialization?

Assigning an initial value to a variable.

Example:

```csharp
int age = 25;
```

---

## Q4. Can a variable's value change?

Yes.

That's why it is called a **variable**.

---

# Assignments

## Assignment 1 – Declare Variables

Create variables for:

- Your name
- Your age
- Your height
- Your weight
- Whether you are a student (`true`/`false`)

Print all of them using `Console.WriteLine()`.

---

## Assignment 2 – Update Values

Create a variable:

```csharp
int marks = 50;
```

Change it to:

- 60
- 75
- 95

Print the value after each update.

Observe that the variable always stores only the latest value.

---

## Assignment 3 – Naming Practice

Identify which variable names are valid and which are invalid. Explain why.

```csharp
int age;
int Age;
int studentAge;
int student_age;
int 1student;
int student1;
int first name;
int @class;
```

> **Note:** `@class` is a special case in C# that we'll discuss later.

---

## Assignment 4 – Create a Student Profile

Declare and initialize variables for:

- Student Name
- Age
- College Name
- Branch
- Percentage
- Phone Number
- City
- IsPlaced (`true`/`false`)

Print them in a readable format.

---

## Assignment 5 – Think Before Coding

Choose the most appropriate data type for each item:

- Number of students in a class
- Price of a laptop
- Person's name
- Whether a light is ON or OFF
- Grade ('A', 'B', 'C')
- Mobile number

> We'll formally learn the available data types in the next chapter.

---

# Next Chapter

# 📘 Data Types

You'll learn:

- What kinds of values variables can store.
- Why choosing the correct data type matters.
- How data types affect memory and performance.

Understanding variables first makes learning data types much easier.
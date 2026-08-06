# 📘 Data Types (Modern C# 2026)

---

# 1. What is a Data Type?

Let's start with a real-life example.

Imagine you have three containers:

- 💧 Water Bottle
- ⛽ Petrol Tank
- 🍱 Lunch Box

Can you store petrol in the lunch box?

Yes... but it's not designed for it.

Can you store rice in the water bottle?

Not conveniently.

Each container is designed for a specific type of content.

Computers work the same way.

A variable needs to know **what type of data it will store**.

That type is called a **Data Type**.

---

## Definition

> **A Data Type tells the compiler:**
>
> - What kind of value can be stored.
> - How much memory to reserve.
> - What operations are allowed on that value.

Example:

```csharp
int age = 25;
```

`int` tells C#:

- Store whole numbers.
- Reserve **4 bytes** of memory.
- Allow arithmetic operations.

---

# 2. Why Do We Need Data Types?

Suppose C# had only one type.

```csharp
Data value;
```

Now store:

```text
25
```

Is it:

- Age?
- Salary?
- Phone Number?
- Temperature?

The compiler doesn't know.

Now suppose:

```text
'A'
```

Should it:

- Perform addition?
- Compare it?
- Print it?

Without data types, the compiler wouldn't know how to interpret or process values.

---

# 3. Categories of Data Types

There are many data types in C#, but for now we'll focus on the most common ones.

| Category | Data Types |
|----------|------------|
| Integer | byte, short, int, long |
| Decimal Numbers | float, double, decimal |
| Characters | char |
| Text | string |
| True / False | bool |
| Generic | object |
| Implicit Typing | var |

---

# 4. Integer Data Types

Used for **whole numbers**.

No decimal point.

Example:

```csharp
int students = 45;
```

---

## byte

### Memory

- 1 byte

### Range

- 0 to 255

Example:

```csharp
byte age = 25;
```

Use for:

- RGB color values
- Small counters
- Months (1–12)

---

## short

### Memory

- 2 bytes

### Range

- -32,768 to 32,767

Example:

```csharp
short temperature = -10;
```

Rarely used in day-to-day application code.

---

## int ⭐⭐⭐⭐⭐

### Memory

- 4 bytes

### Range

```text
-2,147,483,648
to
 2,147,483,647
```

Example:

```csharp
int population = 500000;
```

> `int` is the default integer type in C#.

Use `int` unless you have a reason to choose another integer type.

---

## long

### Memory

- 8 bytes

### Range

Very large numbers.

Example:

```csharp
long distance = 9876543210L;
```

Notice the `L` suffix.

It tells the compiler the literal is a `long`.

---

# 5. Decimal Number Types

Used for numbers with decimal places.

---

## float

### Memory

- 4 bytes

Example:

```csharp
float height = 5.8f;
```

Notice the `f`.

Without it:

```csharp
float height = 5.8;
```

❌ Compilation Error

---

## double ⭐⭐⭐⭐⭐

### Memory

- 8 bytes

Example:

```csharp
double pi = 3.1415926535;
```

This is the default floating-point type.

---

## decimal ⭐⭐⭐⭐⭐

### Memory

- 16 bytes

Example:

```csharp
decimal salary = 55000.75m;
```

Notice the `m`.

Without it:

```csharp
decimal salary = 55000.75;
```

❌ Compilation Error

---

## Why Does `decimal` Exist?

Suppose:

```csharp
double a = 0.1;
double b = 0.2;

Console.WriteLine(a + b);
```

The result may not be exactly **0.3** because `double` stores values in binary floating-point format.

Now:

```csharp
decimal a = 0.1m;
decimal b = 0.2m;

Console.WriteLine(a + b);
```

Output:

```text
0.3
```

That's why **financial calculations** use `decimal`.

---

# 6. char

Stores **one Unicode character**.

Example:

```csharp
char grade = 'A';
```

Uses **single quotes**.

✅

```text
'A'
```

Not

❌

```text
"A"
```

---

# 7. string

Stores text.

Example:

```csharp
string name = "Lokesh";
```

Uses **double quotes**.

```text
"Lokesh"
```

---

## Difference

```csharp
char letter = 'A';

string word = "A";
```

- `char` stores one character.
- `string` stores text.

---

# 8. bool

Stores only two values.

```text
true
false
```

Example:

```csharp
bool isLoggedIn = true;
```

Useful for yes/no questions.

---

# 9. object

The parent of all C# types.

Can store almost anything.

Example:

```csharp
object value = 25;

value = "Lokesh";

value = true;
```

We'll revisit this when we learn **Object-Oriented Programming (OOP)**.

Avoid using `object` unless you specifically need it.

---

# 10. var (Implicit Typing)

Modern C# introduced `var`.

Example:

```csharp
var age = 25;
```

The compiler automatically decides:

```text
int
```

Another example:

```csharp
var name = "Lokesh";
```

Compiler decides:

```text
string
```

This is called **implicit typing**.

---

## Important

Once assigned, the type is fixed.

```csharp
var age = 25;

age = "Lokesh";
```

❌ Error

The compiler already decided `age` is an `int`.

---

## Should Beginners Use `var`?

**Recommendation:**

Not yet.

Learn explicit types first.

```csharp
int age = 25;
```

Once you're comfortable, start using `var` where it improves readability.

---

# 11. Nullable Types

Normally:

```csharp
int age;
```

must contain an integer value before it's used.

Sometimes a value is unknown.

Example:

> Date of Birth: Not entered yet.

Instead of inventing a fake value like `0`, C# lets you say the value is currently missing.

```csharp
int? age = null;
```

Another example:

```csharp
bool? isVerified = null;
```

Possible values:

- true
- false
- null

We'll explore nullable types more deeply later.

---

# 12. Choosing the Right Data Type

| Situation | Recommended Type |
|-----------|------------------|
| Age | int |
| Student Count | int |
| Bank Balance | decimal |
| Height | double |
| Grade | char |
| Name | string |
| Is Logged In | bool |
| Mobile Number | string |
| Population of Earth | long |

---

# 13. Best Practices

- ✔ Use `int` for most whole numbers.
- ✔ Use `decimal` for money.
- ✔ Use `double` for scientific calculations.
- ✔ Store phone numbers as `string`.
- ✔ Use descriptive variable names.
- ✔ Prefer explicit types while learning.

---

# 14. Common Beginner Mistakes

## Wrong

```csharp
int price = 25.5;
```

Reason:

`int` cannot store decimal values.

---

## Wrong

```csharp
char grade = "A";
```

Reason:

`char` uses single quotes.

Correct:

```csharp
char grade = 'A';
```

---

## Wrong

```csharp
string letter = 'A';
```

Correct:

```csharp
string letter = "A";
```

---

## Wrong

```csharp
float value = 10.5;
```

Correct:

```csharp
float value = 10.5f;
```

---

## Wrong

```csharp
decimal amount = 100.5;
```

Correct:

```csharp
decimal amount = 100.5m;
```

---

# Assignments

## Assignment 1 – Declare One Variable of Each Type

Create variables using:

- byte
- short
- int
- long
- float
- double
- decimal
- char
- string
- bool

Print every variable.

---

## Assignment 2 – Student Profile (Correct Data Types)

Store the following using the most appropriate data type:

- Name
- Age
- Height (cm)
- Weight (kg)
- Percentage
- Grade
- Phone Number
- Is Graduated

Print the profile.

---

## Assignment 3 – Find the Errors

Identify and fix the errors.

```csharp
int price = 99.99;

char letter = "A";

string name = 'Lokesh';

float weight = 75.5;

decimal salary = 50000.75;

bool value = "true";
```

Explain why each line is wrong.

---

## Assignment 4 – Choose the Correct Data Type

Choose the best data type for:

- Roll Number
- Passport Number
- Temperature
- Product Price
- Currency Exchange Rate
- Gender (single character)
- Email Address
- Number of Employees
- Is Email Verified
- Total Distance to the Moon

---

## Assignment 5 – Explore Limits

Create variables with the minimum and maximum values for:

- byte
- short
- int
- long

Print them to observe the supported ranges.

---

# Next Chapter

# 📘 Operators

You'll learn:

- Arithmetic Operators
- Assignment Operators
- Comparison Operators
- Logical Operators
- Increment & Decrement Operators
- Operator Precedence

Understanding data types makes learning operators much easier because operators behave differently depending on the types they work with.
# 📘 Operators (Modern C# 2026)

---

# 1. What is an Operator?

## Definition

> **An operator is a symbol that performs an operation on one or more values (called operands).**

Example:

```csharp
int result = 10 + 5;
```

Here:

- `10` → Operand
- `5` → Operand
- `+` → Operator

The operator tells C# what action to perform.

---

# 2. Why Do We Need Operators?

Suppose operators didn't exist.

Instead of writing:

```csharp
int total = 10 + 20;
```

Imagine writing:

- Take value `10`.
- Take value `20`.
- Add them.
- Store the result.

Operators provide a short and standardized way to perform these actions.

---

# 3. Categories of Operators

| Category | Operators |
|----------|-----------|
| Arithmetic | `+` `-` `*` `/` `%` |
| Assignment | `=` `+=` `-=` `*=` `/=` `%=` |
| Comparison | `==` `!=` `>` `<` `>=` `<=` |
| Logical | `&&` `||` `!` |
| Increment / Decrement | `++` `--` |

> **Note:** There are more operator categories (bitwise, ternary, null-coalescing, pattern matching, etc.), but we'll learn those later.

---

# 4. Arithmetic Operators

Used for mathematical calculations.

---

## Addition (`+`)

```csharp
int a = 10;
int b = 20;

int result = a + b;

Console.WriteLine(result);
```

Output:

```text
30
```

---

## Subtraction (`-`)

```csharp
int result = 20 - 5;
```

Output:

```text
15
```

---

## Multiplication (`*`)

```csharp
int result = 5 * 6;
```

Output:

```text
30
```

---

## Division (`/`)

```csharp
int result = 10 / 2;
```

Output:

```text
5
```

### Important

```csharp
int result = 10 / 3;
```

Output:

```text
3
```

Not:

```text
3.333
```

Why?

Because both operands are `int`.

The decimal part is discarded (truncated).

To get a decimal result:

```csharp
double result = 10.0 / 3;
```

Output:

```text
3.333333333...
```

---

## Modulus (`%`)

Returns the remainder after division.

Example:

```csharp
10 % 3
```

Output:

```text
1
```

Another example:

```csharp
20 % 5
```

Output:

```text
0
```

Used heavily for checking **even** and **odd** numbers.

Example:

```csharp
if (number % 2 == 0)
{
    Console.WriteLine("Even");
}
```

---

# 5. Assignment Operators

Used to assign or update values.

---

## Assignment (`=`)

Assigns a value.

```csharp
int age = 25;
```

---

## Addition Assignment (`+=`)

```csharp
int marks = 50;

marks += 10;
```

Equivalent to:

```csharp
marks = marks + 10;
```

Output:

```text
60
```

---

## Subtraction Assignment (`-=`)

```csharp
marks -= 5;
```

Equivalent to:

```csharp
marks = marks - 5;
```

---

## Multiplication Assignment (`*=`)

```csharp
marks *= 2;
```

Equivalent to:

```csharp
marks = marks * 2;
```

---

## Division Assignment (`/=`)

```csharp
marks /= 2;
```

Equivalent to:

```csharp
marks = marks / 2;
```

---

## Modulus Assignment (`%=`)

```csharp
marks %= 3;
```

Equivalent to:

```csharp
marks = marks % 3;
```

---

# 6. Comparison Operators

Comparison operators always return a `bool`.

---

## Equal To (`==`)

Checks whether two values are equal.

```csharp
10 == 10
```

Result:

```text
true
```

---

## Not Equal To (`!=`)

Checks whether two values are different.

```csharp
10 != 5
```

Result:

```text
true
```

---

## Greater Than (`>`)

```csharp
20 > 15
```

Result:

```text
true
```

---

## Less Than (`<`)

```csharp
5 < 10
```

Result:

```text
true
```

---

## Greater Than or Equal To (`>=`)

```csharp
age >= 18
```

---

## Less Than or Equal To (`<=`)

```csharp
marks <= 35
```

---

# 7. Logical Operators

Logical operators combine or invert boolean expressions.

---

## AND (`&&`)

Returns `true` only if **both** conditions are true.

Example:

```csharp
age > 18 && age < 60
```

| Left | Right | Result |
|------|-------|--------|
| true | true | true |
| true | false | false |
| false | true | false |
| false | false | false |

---

## OR (`||`)

Returns `true` if **at least one** condition is true.

Example:

```csharp
isAdmin || isManager
```

| Left | Right | Result |
|------|-------|--------|
| true | true | true |
| true | false | true |
| false | true | true |
| false | false | false |

---

## NOT (`!`)

Reverses a boolean value.

```csharp
bool isLoggedIn = true;

Console.WriteLine(!isLoggedIn);
```

Output:

```text
False
```

---

# 8. Increment Operator (`++`)

Adds **1** to a variable.

```csharp
int number = 5;

number++;
```

Result:

```text
6
```

Equivalent to:

```csharp
number = number + 1;
```

---

# 9. Decrement Operator (`--`)

Subtracts **1** from a variable.

```csharp
number--;
```

Equivalent to:

```csharp
number = number - 1;
```

---

# 10. Prefix vs Postfix (Preview)

There are two ways to increment or decrement.

## Prefix

```csharp
++number;
```

## Postfix

```csharp
number++;
```

Both increase the value by **1**.

There is an important difference when used inside expressions, which we'll cover later when discussing expression evaluation.

---

# 11. Operator Precedence (Basic)

Example:

```csharp
int result = 10 + 5 * 2;
```

Output:

```text
20
```

Not:

```text
30
```

Because multiplication happens before addition.

Use parentheses to make your intent clear.

```csharp
int result = (10 + 5) * 2;
```

Output:

```text
30
```

---

# 12. Common Beginner Mistakes

## Mistake 1

```csharp
if (age = 18)
```

❌ Wrong

This is an **assignment**.

Correct:

```csharp
if (age == 18)
```

This is a **comparison**.

---

## Mistake 2

```csharp
10 / 3
```

Expecting:

```text
3.333
```

Actually gets:

```text
3
```

Because integer division discards the decimal part.

---

## Mistake 3

```csharp
bool value = 10 > 5;
```

Many beginners think this is wrong.

It is actually **correct**.

Comparison operators return a `bool`.

---

## Mistake 4

```csharp
marks =+ 10;
```

This is **not** the same as:

```csharp
marks += 10;
```

`marks =+ 10`

Assigns positive `10` to `marks`.

`marks += 10`

Adds `10` to the existing value.

---

# 13. Best Practices

- ✔ Use parentheses when expressions become complex.
- ✔ Use `==` for comparisons and `=` only for assignments.
- ✔ Prefer compound assignment operators (`+=`, `-=`, etc.) when updating a variable.
- ✔ Keep logical conditions readable instead of combining too many checks into one line.

---

# Assignments

## Assignment 1 – Arithmetic Operators

Create two integers and demonstrate:

- `+`
- `-`
- `*`
- `/`
- `%`

Print each result.

---

## Assignment 2 – Assignment Operators

Start with:

```csharp
int marks = 50;
```

Demonstrate:

- `+=`
- `-=`
- `*=`
- `/=`
- `%=`

Print the value after each operation.

---

## Assignment 3 – Comparison Operators

Create two integers.

Print the result of:

- `==`
- `!=`
- `>`
- `<`
- `>=`
- `<=`

---

## Assignment 4 – Logical Operators

Create:

```csharp
bool hasLicense = true;
bool hasHelmet = false;
```

Demonstrate:

- `&&`
- `||`
- `!`

Print each result.

---

## Assignment 5 – Increment and Decrement

Start with:

```csharp
int count = 10;
```

Show:

```csharp
count++;
++count;
count--;
--count;
```

Print after each step.

---

## Assignment 6 – Operator Precedence

Predict the output before running the code, then verify it.

```csharp
10 + 5 * 2
```

```csharp
(10 + 5) * 2
```

```csharp
20 / 5 + 3
```

```csharp
20 / (5 + 3)
```

Write down:

- Your prediction
- The actual output

---

# Automation Testing Connection

You'll use these operators constantly in Selenium and Reqnroll automation.

- `==` and `!=` for assertions and validations.
- `&&` and `||` for combining test conditions.
- `!` to check that something is **not** present or **not** enabled.
- `++` in loops while iterating through collections.
- `%` occasionally for logic like alternating rows or checking even/odd positions.

Mastering these now will make your automation code much easier to understand.

---

# Next Chapter

# 📘 Type Conversion

You'll learn:

- Implicit Conversion
- Explicit Conversion (Casting)
- `Convert` Class
- `Parse()`
- `TryParse()`
- Overflow
- `checked` and `unchecked`

Understanding operators prepares you for type conversion because many expressions involve values of different data types.
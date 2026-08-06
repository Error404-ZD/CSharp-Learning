# 📘 Module 10 – Arrays (Modern C# 2026)

---

# Before We Begin...

Congratulations.

Up until now you've learned:

✔ Variables
✔ Data Types
✔ Operators
✔ Type Conversion
✔ User Input
✔ Strings
✔ Decision Making
✔ Loops
✔ Methods

Now comes one of the most important topics in programming.

> **Arrays.**

Arrays are your first real **data structure**.

Everything after this (Lists, Dictionaries, Databases, JSON, APIs...) becomes easier because arrays teach you how programmers think about collections of data.

---

# Chapter 1 — Why Do Arrays Exist?

Let's forget C# for a moment.

Imagine you're a class teacher.

You have **5 students**.

Their marks are:

Lokesh → 98

Anirudh → 84

Praneetha → 91

Dhanush → 76

Aditya → 88

Without arrays you would probably write:

```csharp
int lokesh = 98;
int anirudh = 84;
int praneetha = 91;
int dhanush = 76;
int aditya = 88;
```

Looks okay.

Now imagine...

Your school has **500 students**.

Would you create

```text
student1
student2
student3
...

student500
```

Of course not.

Imagine **Google**.

They store information about billions of users.

Would they create

```text
user1
user2
user3
```

Impossible.

So humans naturally solve this problem by making a **list**.

Like this:

```text
98
84
91
76
88
```

Instead of

500 variables,

you have

ONE variable

that stores

500 values.

That is exactly what an Array is.

---

# Human Thinking

Instead of saying

"I have 500 variables."

You say

"I have ONE collection containing 500 values."

Arrays copy the same idea.

---

# Real Life Examples

Marks of students

```text
98
84
91
76
88
```

Employee IDs

```text
102
105
201
654
889
```

Cities

```text
Delhi
Mumbai
Hyderabad
Vijayawada
Chennai
```

Browser names

```text
Chrome
Edge
Firefox
Safari
```

URLs

```text
google.com
github.com
chatgpt.com
```

Automation engineers use arrays every day.

---

# Chapter 2 — What is an Array?

## Definition

An array is a fixed-size collection of elements of the same data type stored together in memory.

That sounds scary.

Let's simplify it.

An array is simply

> One variable that stores many values of the same type.

---

Example

```csharp
int[] marks =
{
    98,
    84,
    91,
    76,
    88
};
```

Notice something.

We created

ONE variable

called

```text
marks
```

Inside it

five integers are stored.

---

# Why Same Data Type?

Valid

```csharp
int[] marks =
{
    90,
    80,
    70
};
```

Invalid

```csharp
int[] marks =
{
    90,
    "Lokesh",
    true
};
```

Why?

Because

`int[]`

means

"Store ONLY integers."

Similarly

```csharp
string[]
```

means

Store only strings.

---

# Memory Visualization

Suppose

```csharp
int[] numbers =
{
    10,
    20,
    30,
    40,
    50
};
```

You imagine

```text
10
20
30
40
50
```

Computer imagines

```text
+----+----+----+----+----+
|10  |20  |30  |40  |50  |
+----+----+----+----+----+
```

Each box stores one value.

---

# Memory Addresses

The computer also remembers where every value lives.

Imagine

```text
Address

1000
1004
1008
1012
1016
```

Each integer occupies memory.

Arrays store these values continuously.

That's one reason arrays are very fast.

---

# Chapter 3 — Index vs Length

This is the biggest beginner confusion.

Let's clear it forever.

Suppose

```csharp
string[] names =
{
    "A",
    "B",
    "C",
    "D",
    "E"
};
```

How many elements exist?

```text
5
```

That is called

## Length

```csharp
Console.WriteLine(names.Length);
```

Output

```text
5
```

---

Now...

How do we access them?

Not using

1

2

3

4

5

Instead

C# uses

```text
Index

0
1
2
3
4
```

Visual

```text
Index

0    1    2    3    4

+----+----+----+----+----+
| A  | B  | C  | D  | E  |
+----+----+----+----+----+

Length = 5
```

Notice

Length

is

5

Last Index

is

4

Relationship

```text
Last Index = Length - 1
```

This is one of the most important rules in programming.

---

# Why Does Index Start at 0?

Imagine you're standing at your house.

Your friend asks

"How far is your house?"

Answer

0 km

The next shop

1 km away

Hospital

2 km away

Index works exactly like that.

Index means

> How far away from the beginning is this element?

First element

0 away.

Second element

1 away.

Third element

2 away.

That's why every programming language starts arrays at zero.

---

# Chapter 4 — Creating Arrays

There are multiple ways.

---

## Method 1 (Most Common)

```csharp
int[] marks =
{
    98,
    84,
    91,
    76
};
```

This is called

Array Initializer.

You'll use this most often.

---

## Method 2

```csharp
int[] marks = new int[5];
```

Meaning

Create an array capable of storing

5 integers.

Initially

```text
0
0
0
0
0
```

Because integers default to 0.

---

Example

```csharp
marks[0] = 95;
marks[1] = 84;
```

---

## Method 3

```csharp
string[] cities = new string[]
{
    "Delhi",
    "Mumbai",
    "Hyderabad"
};
```

Perfectly valid.

---

## Empty Arrays

Sometimes you want an array that contains nothing.

```csharp
int[] numbers = [];
```

or

```csharp
Array.Empty<int>();
```

We'll discuss when these are useful later.

---

## Modern C# (Collection Expressions)

Modern C# introduced

```csharp
int[] numbers =
[
    10,
    20,
    30
];
```

Cleaner.

More readable.

This is becoming increasingly common in modern C# projects.

---

# Chapter 5 — Accessing Array Elements

Suppose

```csharp
string[] names =
{
    "Lokesh",
    "Anirudh",
    "Praneetha"
};
```

Access first element

```csharp
Console.WriteLine(names[0]);
```

Output

```text
Lokesh
```

Second

```csharp
Console.WriteLine(names[1]);
```

Output

```text
Anirudh
```

---

Last element

```csharp
Console.WriteLine(names[names.Length - 1]);
```

Never hardcode

```csharp
names[2]
```

Because tomorrow another name may be added.

Using

```csharp
Length - 1
```

makes your code future-proof.

---

# Updating Elements

Arrays are mutable.

Meaning

Their contents can change.

Example

```csharp
int[] marks =
{
    80,
    85,
    90
};
```

Update

```csharp
marks[1] = 100;
```

Now

```text
80
100
90
```

---

# Index Out Of Range

Suppose

```csharp
int[] numbers =
{
    10,
    20,
    30
};
```

Indexes are

```text
0
1
2
```

Now imagine

```csharp
Console.WriteLine(numbers[3]);
```

C# says

> There is no fourth element.

Exception

```text
IndexOutOfRangeException
```

Always remember

```text
Valid Indexes

0

↓

Length - 1
```

Never beyond.

---

# Common Beginner Mistakes

❌

Thinking Length is the last index.

Wrong

```text
Length = 5

Last Index = 4
```

---

❌

Using

```csharp
<= numbers.Length
```

instead of

```csharp
< numbers.Length
```

This causes IndexOutOfRangeException.

---

❌

Hardcoding indexes

```csharp
numbers[4]
```

Prefer

```csharp
numbers[numbers.Length - 1]
```

---

# Chapter 6 — Traversing Arrays

Imagine I hand you a box containing 100 exam papers.

You need to check every paper.

Would you randomly pick papers?

No.

You start from the first.

Read it.

Move to the second.

Read it.

Move to the third.

Repeat until the last paper.

This process is called

> Traversing.

In programming,

Traversing means

Visiting every element in the array exactly once.

Loops make this possible.

We'll use two loops most often:

- `for`
- `foreach`

In the next section, we'll learn not just the syntax, but **why both exist**, when to choose each one, and how experienced developers think about them.

---

# End of Part 1

Next:

📘 Part 2

- `for` vs `foreach`
- Array Algorithms (Highest, Lowest, Sum, Average...)
- Search
- Reverse
- Copy
- The thinking process behind each algorithm

# 📘 Module 10 – Arrays (Modern C# 2026)

# Part 2 — Traversing Arrays & Array Algorithms

---

# Chapter 7 — Why Do We Need Loops?

Suppose you have this array.

```csharp
int[] marks =
{
    98,
    84,
    91,
    76,
    88
};
```

You can print them manually.

```csharp
Console.WriteLine(marks[0]);
Console.WriteLine(marks[1]);
Console.WriteLine(marks[2]);
Console.WriteLine(marks[3]);
Console.WriteLine(marks[4]);
```

Works.

But...

What if tomorrow there are

100 students?

Would you write

```csharp
Console.WriteLine(marks[99]);
```

100 times?

Of course not.

This is exactly why loops exist.

A loop says

> "Do the same work repeatedly."

---

Imagine you're checking exam papers.

You don't tell yourself

Read paper 1

Read paper 2

Read paper 3

...

Instead you naturally think

> Keep reading papers until there are no papers left.

Loops copy human thinking.

---

# Chapter 8 — for Loop

Suppose

```csharp
int[] marks =
{
    98,
    84,
    91,
    76,
    88
};
```

We want to print every mark.

```csharp
for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}
```

Let's understand every part.

---

## Step 1

```csharp
int i = 0;
```

Where should we start?

Answer

First element.

First element's index

```text
0
```

So

```text
i = 0
```

---

## Step 2

```csharp
i < marks.Length
```

Question

Should we continue?

Imagine

Length

```text
5
```

Indexes

```text
0

1

2

3

4
```

Keep going while

```text
i < 5
```

Once

```text
i = 5
```

Stop.

---

## Step 3

```csharp
i++
```

Move to the next element.

Exactly like moving to the next exam paper.

---

Iteration

```text
i = 0

↓

Print marks[0]

↓

i++

↓

i = 1

↓

Print marks[1]

↓

i++

↓

i = 2

...

↓

Finished
```

---

# Human Thinking

Start at the beginning.

↓

Read it.

↓

Move one step.

↓

Read again.

↓

Repeat until finished.

That is literally a for loop.

---

# When Do We Use for?

Use a for loop whenever you need

✔ Index

✔ Position

✔ Modify elements

✔ Move forwards

✔ Move backwards

---

Example

```csharp
marks[2] = 100;
```

Only possible because we know the index.

---

# Chapter 9 — foreach Loop

Suppose

```csharp
string[] names =
{
    "Lokesh",
    "Anirudh",
    "Praneetha"
};
```

Instead of

```csharp
for(...)
```

We can write

```csharp
foreach(string name in names)
{
    Console.WriteLine(name);
}
```

Think about English.

> For each student...

Print student.

Exactly.

---

Imagine a teacher calling attendance.

Teacher doesn't care

Student number

Student index

Memory address.

Teacher simply says

Next student.

Next student.

Next student.

That's foreach.

---

# Difference

for

```text
I need POSITION.
```

foreach

```text
I only need VALUE.
```

---

Example

Need position?

```text
Student 1

Student 2

Student 3
```

Use

for

---

Need only values?

```text
Lokesh

Anirudh

Praneetha
```

Use

foreach

---

# Which One Should Beginners Prefer?

Reading values?

Use

```csharp
foreach
```

Changing values?

Use

```csharp
for
```

Professional developers do exactly the same.

---

# Chapter 10 — Programming Logic

Everything below follows the same thinking process.

Always remember

Humans think first.

Then code.

Never the other way around.

---

# Algorithm 1 — Finding Highest Number

Suppose

```text
98

84

91

76

88
```

Question

Who scored highest?

Did your brain compare

84

with nothing?

No.

Your brain naturally assumes

```text
98
```

is highest.

Then asks

Is

84

bigger?

No.

↓

Is

91

bigger?

No.

↓

Is

76

bigger?

No.

↓

Is

88

bigger?

No.

Finished.

Highest

98

---

Human Thinking

Assume first value is highest.

↓

Compare next value.

↓

If bigger

Replace highest.

↓

Continue.

---

Now C#

```csharp
int[] marks =
{
    98,
    84,
    91,
    76,
    88
};

int highest = marks[0];

for(int i = 1; i < marks.Length; i++)
{
    if(marks[i] > highest)
    {
        highest = marks[i];
    }
}

Console.WriteLine(highest);
```

Notice

We started from

```text
i = 1
```

Why?

Because

The first value

was already assumed to be highest.

No need to compare it with itself.

---

# Algorithm 2 — Finding Lowest Number

Exactly opposite.

Human Thinking

Assume first value is smallest.

↓

Compare.

↓

If smaller

Replace.

Code

```csharp
int lowest = marks[0];

for(int i = 1; i < marks.Length; i++)
{
    if(marks[i] < lowest)
    {
        lowest = marks[i];
    }
}
```

Notice

Only one thing changed.

```text
>

became

<
```

That's it.

---

# Algorithm 3 — Finding Sum

Suppose

```text
98

84

91

76

88
```

Human Thinking

Start with

```text
0
```

Add

98

↓

182

↓

273

↓

349

↓

437

Finished.

---

C#

```csharp
int sum = 0;

for(int i = 0; i < marks.Length; i++)
{
    sum += marks[i];
}
```

Same logic.

---

# Algorithm 4 — Finding Average

Question

How do humans calculate average?

Answer

Add everything.

↓

Divide by total count.

Exactly.

C#

```csharp
double average =
(double)sum / marks.Length;
```

Remember

Average always needs

Sum first.

---

# Algorithm 5 — Count Even Numbers

Suppose

```text
2

5

8

11

14
```

Question

How many are even?

Human Thinking

Start count

0

↓

2

Even?

Yes

Count = 1

↓

5

No

↓

8

Yes

Count = 2

↓

11

No

↓

14

Yes

Count = 3

Finished.

---

Code

```csharp
int count = 0;

for(int i = 0; i < numbers.Length; i++)
{
    if(numbers[i] % 2 == 0)
    {
        count++;
    }
}
```

---

# Algorithm 6 — Count Odd Numbers

Exactly opposite.

```csharp
if(numbers[i] % 2 != 0)
```

Done.

---

# Algorithm 7 — Search an Element

Suppose

Looking for

```text
91
```

Human Thinking

98?

No.

↓

84?

No.

↓

91?

YES.

Stop searching.

---

Code

```csharp
bool found = false;

for(int i = 0; i < marks.Length; i++)
{
    if(marks[i] == 91)
    {
        found = true;
        break;
    }
}

Console.WriteLine(found);
```

Notice

`break`

stops the loop immediately.

---

# Algorithm 8 — Reverse an Array

Imagine reading a book.

Normally

Page

1

2

3

4

5

Reverse

5

4

3

2

1

Exactly the same idea.

Instead of

```text
0 → Length
```

Go

```text
Length-1 → 0
```

```csharp
for(int i = marks.Length - 1; i >= 0; i--)
{
    Console.WriteLine(marks[i]);
}
```

---

# Algorithm 9 — Copy an Array

Imagine copying marks from one notebook to another.

Notebook 1

```text
98

84

91
```

Notebook 2

Initially

```text
0

0

0
```

Copy one by one.

```csharp
int[] copy = new int[marks.Length];

for(int i = 0; i < marks.Length; i++)
{
    copy[i] = marks[i];
}
```

Now both arrays contain the same values.

---

# Think Like a Programmer

Whenever someone asks you a logic question:

❌ Don't think about C# first.

Ask yourself:

> "If I had to solve this with paper and pencil, what would I do?"

Once you know the human steps, translating them into C# becomes much easier.

This is exactly how experienced programmers approach new problems.

---

# End of Part 2

Next:

📘 Part 3

- Multi-dimensional Arrays
- Jagged Arrays
- Array Methods
- ToCharArray()
- Arrays vs Collections
- Arrays in Selenium Automation
- Best Practices
- Interview Questions
- Progressive Assignments

# 📘 Module 10 – Arrays (Modern C# 2026)

# Part 3 — Advanced Arrays, Array Methods & Interview Preparation

---

# Chapter 11 — Multi-dimensional Arrays

## Why Do They Exist?

Imagine you're a class teacher.

You have marks like this:

| Student | Math | Science | English |
|---------|------|----------|----------|
| Lokesh | 95 | 88 | 91 |
| Aditya | 82 | 79 | 86 |
| Anirudh | 98 | 96 | 94 |

Can a normal array represent this?

```csharp
int[] marks =
{
    95,
    88,
    91,
    82,
    79,
    86
};
```

Technically yes.

But...

Can you immediately tell

Which marks belong to Lokesh?

No.

We've lost the relationship between rows and columns.

---

## Solution

Store information like a table.

```csharp
int[,]
```

A multidimensional array represents data in rows and columns.

---

Example

```csharp
int[,] marks =
{
    {95,88,91},
    {82,79,86},
    {98,96,94}
};
```

Visual

```text
        Math Science English

Lokesh    95      88      91

Aditya    82      79      86

Anirudh   98      96      94
```

---

## Accessing Elements

```csharp
marks[0,0]
```

Meaning

```text
Row 0

Column 0
```

Result

```text
95
```

---

Another

```csharp
marks[2,1]
```

Means

```text
Third row

Second column
```

Result

```text
96
```

---

# Traversing a Multi-dimensional Array

Question

How do humans read a table?

Row by row.

Exactly.

That means

Outer loop

↓

Rows

Inner loop

↓

Columns

```csharp
for(int row = 0; row < marks.GetLength(0); row++)
{
    for(int column = 0; column < marks.GetLength(1); column++)
    {
        Console.Write(marks[row,column] + " ");
    }

    Console.WriteLine();
}
```

---

## What is GetLength()?

Unlike a normal array,

A table has

Rows

AND

Columns.

So

```csharp
marks.GetLength(0)
```

returns

Number of rows.

Example

```text
3
```

---

```csharp
marks.GetLength(1)
```

returns

Number of columns.

Example

```text
3
```

Think

```text
Dimension 0

↓

Rows

Dimension 1

↓

Columns
```

---

# Real-world Uses

Student marks

Chess boards

Excel sheets

Calendar

Cinema seating

Game maps

Image pixels

---

# Chapter 12 — Jagged Arrays

Suppose

Three students wrote different numbers of exams.

Lokesh

```text
95

91
```

Aditya

```text
88

84

79

92
```

Anirudh

```text
100
```

Can a table store this?

No.

Because every row must have the same number of columns.

---

Solution

Each row becomes its own array.

This is called

Jagged Array.

---

Example

```csharp
int[][]
```

```csharp
int[][] marks =
{
    new int[]{95,91},

    new int[]{88,84,79,92},

    new int[]{100}
};
```

Notice

Every row has different length.

---

Visual

```text
Row 0

95

91

----------------

Row 1

88

84

79

92

----------------

Row 2

100
```

---

Traversal

```csharp
foreach(int[] student in marks)
{
    foreach(int mark in student)
    {
        Console.WriteLine(mark);
    }
}
```

Or

```csharp
for(int i = 0; i < marks.Length; i++)
{
    for(int j = 0; j < marks[i].Length; j++)
    {
        Console.WriteLine(marks[i][j]);
    }
}
```

---

# Multi-dimensional vs Jagged Arrays

| Multi-dimensional | Jagged |
|-------------------|---------|
| Rectangle | Irregular |
| Same columns | Different columns |
| Faster indexing | More flexible |
| Tables | Variable-sized data |

---

# Chapter 13 — Important Array Methods

Instead of memorizing methods,

Let's first understand the problem.

---

## Array.Sort()

Imagine you're arranging exam papers

Lowest marks

↓

Highest marks

Instead of sorting manually,

C# already knows how.

```csharp
Array.Sort(numbers);
```

Before

```text
90

65

82

74
```

After

```text
65

74

82

90
```

---

## Array.Reverse()

Problem

You want the opposite order.

```csharp
Array.Reverse(numbers);
```

Before

```text
10

20

30

40
```

After

```text
40

30

20

10
```

---

## Array.IndexOf()

Question

Where is

82

located?

```csharp
int position =
Array.IndexOf(numbers,82);
```

Output

```text
2
```

Returns

The first matching index.

---

## Array.LastIndexOf()

Useful when duplicates exist.

```text
10

20

10

40
```

IndexOf

↓

0

LastIndexOf

↓

2

---

## Array.Exists()

Question

Does this value exist?

Returns

```text
true

false
```

Example

```csharp
bool exists =
Array.Exists(numbers,
number => number > 90);
```

---

## Array.Find()

Question

Give me the first value matching a condition.

```csharp
int result =
Array.Find(numbers,
number => number > 80);
```

---

## Array.FindAll()

Question

Give me every matching value.

```csharp
int[] results =
Array.FindAll(numbers,
number => number > 80);
```

---

## Array.Copy()

Copies elements.

```csharp
Array.Copy(source,destination,source.Length);
```

---

## Array.Clear()

Resets elements.

Integers become

```text
0
```

Strings become

```text
null
```

---

## Array.Resize()

Need a bigger array?

```csharp
Array.Resize(ref numbers,10);
```

Old

```text
Length

5
```

New

```text
Length

10
```

---

# Chapter 14 — char[] and ToCharArray()

Interviewers love this one.

Why?

Because strings are collections of characters.

Suppose

```csharp
string name =
"Lokesh";
```

Visual

```text
L

o

k

e

s

h
```

Sometimes

You don't want the whole word.

You want each character separately.

Example

Count vowels.

Find spaces.

Reverse text.

Check every character.

That's where

```csharp
ToCharArray()
```

comes in.

```csharp
char[] letters =
name.ToCharArray();
```

Now

```text
letters[0]

↓

L

letters[1]

↓

o

letters[2]

↓

k
```

Now loops become possible.

```csharp
foreach(char letter in letters)
{
    Console.WriteLine(letter);
}
```

Automation engineers use this when

Checking passwords

Masking data

Validating characters

Parsing text

Interview questions

---

# Chapter 15 — Arrays vs Collections

Question

If arrays are so good,

Why did Microsoft create collections?

Because arrays have limitations.

---

Problem 1

Fixed size.

```text
Today

5 students

Tomorrow

6 students
```

Array cannot grow automatically.

---

Problem 2

Adding new data

Very inconvenient.

---

Problem 3

Removing data

Also inconvenient.

---

So .NET introduced

Collections.

---

## List<T>

Think

Growing array.

Can increase or decrease in size automatically.

---

## Dictionary<TKey,TValue>

Java calls it

HashMap.

Stores

Key

↓

Value

Example

```text
101

↓

Lokesh

102

↓

Anirudh
```

Instead of searching,

You directly retrieve the value using the key.

Very fast.

---

## HashSet<T>

Stores only unique values.

Duplicates automatically disappear.

---

## Queue<T>

Real-life queue.

First person enters

↓

First person leaves.

FIFO

(First In First Out)

---

## Stack<T>

Stack of plates.

Last plate placed

↓

First plate removed.

LIFO

(Last In First Out)

---

Arrays teach the foundation.

Collections solve the limitations.

---

# Chapter 16 — Arrays in Automation Testing

Automation engineers constantly use arrays.

Example

Testing multiple browsers.

```csharp
string[] browsers =
{
    "Chrome",

    "Edge",

    "Firefox"
};
```

Loop

```csharp
foreach(string browser in browsers)
{
    Console.WriteLine(browser);
}
```

---

Testing multiple URLs

```csharp
string[] urls =
{
    "/login",

    "/dashboard",

    "/profile"
};
```

---

Expected values

```csharp
string[] expectedTitles =
{
    "Login",

    "Dashboard",

    "Settings"
};
```

---

Usernames

```csharp
string[] usernames =
{
    "Admin",

    "Manager",

    "Candidate"
};
```

Arrays appear everywhere in Selenium.

---

# Best Practices

✔ Use meaningful names.

✔ Use Length instead of hardcoded values.

✔ Prefer foreach for reading.

✔ Prefer for when modifying elements.

✔ Avoid magic numbers.

✔ Check boundaries before accessing indexes.

✔ Keep arrays small and focused.

---

# Common Beginner Mistakes

❌ Forgetting that indexing starts at 0.

---

❌ Writing

```csharp
i <= array.Length
```

instead of

```csharp
i < array.Length
```

---

❌ Assuming Length is the last index.

It isn't.

---

❌ Accessing

```csharp
array[Length]
```

Always invalid.

---

❌ Forgetting arrays have fixed size.

---

# Interview Questions

### Q1

What is an array?

---

### Q2

Why does indexing start at 0?

---

### Q3

Difference between

for

and

foreach?

---

### Q4

Difference between

Array

and

List<T>?

---

### Q5

Difference between

Multi-dimensional

and

Jagged arrays?

---

### Q6

What does

ToCharArray()

do?

---

### Q7

Why are arrays faster than lists for indexed access?

---

# Progressive Assignments

## Beginner

✅ Print all elements.

✅ Update an element.

✅ Print first and last element.

---

## Easy

✅ Highest

✅ Lowest

✅ Sum

✅ Average

---

## Medium

✅ Count even numbers.

✅ Count odd numbers.

✅ Search an element.

✅ Reverse an array.

---

## Intermediate

✅ Copy an array.

✅ Sort ascending.

✅ Sort descending.

---

## Advanced Beginner

Using `ToCharArray()`:

- Count vowels in a name.
- Count consonants.
- Count digits.
- Count spaces.
- Reverse a string manually.

---

## Mini Project

Create a **Student Marks Analyzer**.

Features:

- Store marks in an array.
- Display all marks.
- Find highest mark.
- Find lowest mark.
- Calculate total.
- Calculate average.
- Count pass and fail students.
- Search for a mark entered by the user.
- Display marks in ascending order.
- Display marks in descending order.

---


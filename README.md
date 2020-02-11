# C-Type-Casting
C# Type Casting


Type conversion happens when we assign the value of one data type to another. If the data types are compatible, then C# does Automatic Type Conversion. If not comparable, then they need to be converted explicitly which is known as Explicit Type conversion. For example, assigning an int value to a long variable.


1. Implicit Type Casting:
The two data types are compatible.
When we assign value of a smaller data type to a bigger data type.

For Example, in C#, the numeric data types are compatible with each other but no automatic conversion is supported from numeric type to char or boolean. Also, char and boolean are not compatible with each other. Before converting, the compiler first checks the compatibility according to the following figure and then it decides whether it is alright or there some error.


2. Explicit Type Casting:
There may be compilation error when types not compatible with each other. For example, assigning double value to int data type.

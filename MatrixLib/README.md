# MatrixLib
## Classes

 - Matrix
 - Fraction
 - Equation
 
## Matrix
The class uses fractions instead of real numbers. Without them, calculations could return non-neat numbers, for example 1.3333.

What can this class do:
- Transpose
- Calculate the determinant
- Find a minor
- Calculate the algebraic complement
- Find a matrix of algebraic complements
- Find the inverse matrix

Operations with matrices:
- Addition, subtraction, multiplication, division of a matrix by a number
- Addition, subtraction, multiplication, division of a matrix by a matrix

| Properties | What does |
| ------ | ------ |
| T | Returns the transposed matrix |
| Rank | Returns the rank of the matrix |
| Det | Returns the determinant of the matrix |
| Inv | Returns the inverse matrix |
| Rows | Returns the number of rows |
| Columns | Returns the number of columns |

| Methods    | What does |
| ------ | ------ |
| Transpose | Returns the transposed matrix |
| Determinant | Returns the determinant of the matrix |
| CompareSizes(`Matrix`) | Checks whether the matrix is the <br>same as the other in size |
| Clone | Returns a clone of the matrix |
| EmptyMatrix(`int`, `int`) | Returns an N x M matrix filled with zeros |
| CutColumn(`int`) | Returns a matrix without the specified column | 
| CutColumns(`int[]`) | Returns a matrix without the specified columns |
| CutRow(`int`) | Returns a matrix without the specified row | 
| CutRows(`int[]`) | Returns a matrix without the specified rows |
<<<<<<< HEAD
| Pow(`int`) | Returns a matrix to the specified power. `Power must be greater than zero` |  
| Minor(`int`) | Returns the minor of the matrix of the first row and the specified column |
| Minor(`int`, `int`) | Returns the minor of the matrix of the specified row and the specified column | 
| AlgComp(`int`, `int`) | Returns the algebraic complement of the matrix of the specified row and the specified column |
| Display(`string`, `bool`) | Outputs a matrix to the console with the specified text and a new line at the end if the |
| | second parameter is **true**| 
=======
| Pow(`int`) | Returns a matrix to the specified power.<br> `Power must be greater than zero` |  
| Minor(`int`) | Returns the minor of the matrix of the<br> first row and the specified column |
| Minor(`int`, `int`) | Returns the minor of the matrix of the <br>specified row and the specified column | 
| AlgComp(`int`, `int`) | Returns the algebraic complement of the matrix<br> of the specified row and the specified column |
| Display(`string`, `bool`) | Outputs a matrix to the console with the specified text<br> and a new line at the end if the second parameter is **true**| 
>>>>>>> a041f51f3affa24b3b24c59a6f13081688cec432
| SingleMatrix(`int`) |  Returns a unit matrix of size N x N |

## Fraction

A class for creating fractions using the Matrix class.

A fraction can be created from the following types:
- Integer types: sbyte, byte, short, ushort, int, uint, long, ulong
- Real types: float, double, decimal

Operations with fractions:
- Addition, subtraction, multiplication, division of a fraction by a number
- Addition, subtraction, multiplication, division of a fraction by a fraction

| Properties | What does |
| ------ | ------ |
| N | Returns the numerator |
| D | Returns the denominator |
| GCD | Returns the  greatest commom diviser |
| Reduce | Returns a reduced fraction |

| Methods | What does |
| ------ | ------ |
| ReduceArray(`Fraction[]`) | Returns a reduced array of fractions |
| ReduceArray(`Fraction[,]`) | Returns a reduced two-dimensional array of fractions |
| GetRawString | Returns an unformatted fraction |
| ZeroArray(`int`) | Returns an array of fractions equal to zero |
| ZeroArray(`int`, `int`) | Returns a two-dimensional array of fractions equal to zero |
| ToFraction(`T`) | Converts a number to a fraction |

## Equation

Provides methods for solving matrix equations.

| Methods | What does |
| ------ | ------ |
| IsSolvable(`Matrix`) | Returns true if the matrix equation has one solution, otherwise false |
| KramerMethod(`Matrix`) | Returns the roots of the equation |

# Equation examples

## KramerMethod
```cs
<<<<<<< HEAD
double[,] values = {{1,4, 2},{5,1,7}};
=======
double[,] values = {{1,4, 2}, {5,1,7}};
>>>>>>> 4f0fe9d62ea88ea912fb85d781b653eebc0964a5
Matrix A = new Matrix(values);
if(Equation.IsSolvable(A))
{
	Console.WriteLine("Equation is solvable!");
	Console.WriteLine("Solution of equation:");
	Fraction[] solution = Equation.KramerMethod(A);
	for(int i = 0; i < solution.Length; i++)
	Console.WriteLine("x{0} = {1}", i+1, solution[i]);
}
else
Console.WriteLine("Equation is unsolvable!");
```

## Matrix Method Ax = b
```cs
double[,] values = {{1,4, 2},{5,1,7}};
Matrix A = new Matrix(values);
if(Equation.IsSolvable(A))
{
	Console.WriteLine("Equation is solvable!");
	Console.WriteLine("Solution of equation:");
	Fraction[] solution = Equation.MatrixMethod(A);
	for(int i = 0; i < solution.Length; i++)
	Console.WriteLine("x{0} = {1}", i+1, solution[i]);
}
else
Console.WriteLine("Equation is unsolvable!");
```

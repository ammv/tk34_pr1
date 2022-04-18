using System;

namespace MatrixLib
{
	static class Equation
	{
		public static Fraction[] KramerMethod(Matrix A)
		{
			if(!IsSolvable(A))
				throw new Exception("It is impossible to solve the matrix equation, because the determinant is 0");
			
			int rank = A.Columns-1;
			
			Matrix B = A.CutColumn(rank);
			Matrix temp;
			
			Fraction[] solutions = new Fraction[rank];
			Fraction det = B.Det;
			
			for(int i = 0; i < rank; i++)
			{
				temp = B.Clone();
				for(int k = 0; k < rank; k++)
					temp[k,i] = A[k, rank];
				solutions[i] = (temp.Det/det).Reduce;
			}
			return solutions;
		}
		public static bool IsSolvable(Matrix A)
		{
			if(!(A.Columns - 1 == A.Rows) || A.CutColumn(A.Columns-1).Det.Equals(0))
				return false;
			return true;
		}
	}
	
}
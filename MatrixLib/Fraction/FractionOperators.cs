using System;

namespace MatrixLib
{
	public partial class Fraction
	{
		// Add
		public static Fraction operator +(Fraction A, Fraction B)
		{
			long n = A.n*B.d+B.n*A.d;
			long d = A.d*B.d;
			
			if(n < 0 & d < 0)
			{
				n *= -1;
				d *= -1;
			}
			return new Fraction(n, d).Reduce;
		}
		public static Fraction operator +(byte A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(sbyte A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(short A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(ushort A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(int A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(uint A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(long A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(ulong A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(float A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(double A, Fraction B) => ToFraction(A) + B;
		public static Fraction operator +(decimal A, Fraction B) => ToFraction(A) + B;
		
		public static Fraction operator +(Fraction A, byte B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, sbyte B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, short B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, ushort B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, int B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, uint B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, long B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, ulong B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, float B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, double B) => ToFraction(B) + A;
		public static Fraction operator +(Fraction A, decimal B) => ToFraction(B) + A;
		// Sub
		public static Fraction operator -(Fraction A, Fraction B)
		{
			long n = A.n*B.d-B.n*A.d;
			long d = A.d*B.d;
			if(n < 0 & d < 0)
			{
				n *= -1;
				d *= -1;
			}
			return new Fraction(n, d).Reduce;
		}
		public static Fraction operator -(byte A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(sbyte A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(short A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(ushort A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(int A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(uint A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(long A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(ulong A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(float A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(double A, Fraction B) => ToFraction(A) - B;
		public static Fraction operator -(decimal A, Fraction B) => ToFraction(A) - B;
		
		public static Fraction operator -(Fraction A, byte B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, sbyte B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, short B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, ushort B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, int B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, uint B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, long B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, ulong B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, float B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, double B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A, decimal B) => ToFraction(B) - A;
		public static Fraction operator -(Fraction A)
		{
			return new Fraction(-A.n, A.d);
		}
		// Mul
		public static Fraction operator *(Fraction A, Fraction B)
		{
			long n = A.n*B.n;
			long d = A.d*B.d;
			if(n < 0 & d < 0)
			{
				n *= -1;
				d *= -1;
			}
			return new Fraction(n, d).Reduce;
		}
		public static Fraction operator *(byte A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(sbyte A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(short A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(ushort A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(int A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(uint A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(long A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(ulong A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(float A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(double A, Fraction B) => ToFraction(A) * B;
		public static Fraction operator *(decimal A, Fraction B) => ToFraction(A) * B;
										
		public static Fraction operator *(Fraction A, byte B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, sbyte B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, short B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, ushort B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, int B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, uint B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, long B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, ulong B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, float B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, double B) => ToFraction(B) * A;
		public static Fraction operator *(Fraction A, decimal B) => ToFraction(B) * A;
		// Div
		public static Fraction operator /(Fraction A, Fraction B)
		{
			long n = A.n*B.d;
			long d = A.d*B.n;
			if(n < 0 & d < 0)
			{
				n *= -1;
				d *= -1;
			}
			return new Fraction(n, d).Reduce;
		}
		public static Fraction operator /(byte A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(sbyte A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(short A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(ushort A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(int A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(uint A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(long A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(ulong A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(float A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(double A, Fraction B) => ToFraction(A) / B;
		public static Fraction operator /(decimal A, Fraction B) => ToFraction(A) / B;
										
		public static Fraction operator /(Fraction A, byte B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, sbyte B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, short B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, ushort B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, int B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, uint B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, long B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, ulong B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, float B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, double B) => ToFraction(B) / A;
		public static Fraction operator /(Fraction A, decimal B) => ToFraction(B) / A;
		
		public static bool operator >(Fraction A, Fraction B)
		{
			return A.ToDouble() > B.ToDouble();
		}
		public static bool operator >=(Fraction A, Fraction B)
		{
			return A.ToDouble() >= B.ToDouble();
		}
		public static bool operator <(Fraction A, Fraction B)
		{
			return A.ToDouble() < B.ToDouble();
		}
		public static bool operator <=(Fraction A, Fraction B)
		{
			return A.ToDouble() <= B.ToDouble();
		}
	}
}
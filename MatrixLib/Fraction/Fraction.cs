using System;

namespace MatrixLib
{
	public partial class Fraction
	{
		// Numerator and denominator
		long n;
		long d;
		
		public static Fraction Zero = new Fraction(0L,1L);
		
		public long N
		{
			get => n;
			set => n = value;
		}
		public long D
		{
			get => d;
			set
			{
				if(value!=0) d = value;
				else throw new DivideByZeroException("You cannot set denominator to 0s");
			}
		}
		// Greatest common diviser
		public long GCD
		{
			get => _GCD(this);
		}
		// Fraction reduction
		public Fraction Reduce
		{
			get => _Reduce(this);
		}
		// Supported types
		private static Type[] IntTypes = new Type[]
		{
			typeof(byte), typeof(sbyte), typeof(short), typeof(ushort),
			typeof(int), typeof(uint), typeof(long), typeof(ulong)
		};
		private static Type[] FloatTypes = new Type[]
		{
			typeof(float), typeof(double), typeof(decimal)
		};
		public Fraction(long n, long d)
		{
			if(d == 0) throw new DivideByZeroException();
			this.n = n;
			this.d = d;
		}
		public Fraction(long n)
		{
			this.n = n;
			this.d = 1;
		}
		public Fraction()
		{
			this.n = 0;
			this.d = 1;
		}
	}
}
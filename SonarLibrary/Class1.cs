using System;

namespace SonarLibrary
{
    public class Numbers
    {
		public double Root(int x)
		{
			return Math.Sqrt(x);
		}
		public double Divide(int x,int y)
		{
			if(y==0)
			{
				throw new DivideByZeroException();
			}
			return x/y;
		}
		public double Sum(int x,int y)
		{
			return x+y;
		}
		public double Subtract(int x,int y)
		{
			if(y>x)
			{
			throw new ArithmeticException($"Result will be negative. {y} is greater than {x}");
			}
			return x-y;
		}
		public double Product(int x,int y)
		{
			return x*y;
		}
    }
}

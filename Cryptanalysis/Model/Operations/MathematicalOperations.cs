using System.Collections.Generic;

namespace Cryptanalysis
{
	public static class MathematicalOperations
	{
		#region Public methods

		public static int GetGreatestCommonDivisor(int number1, int number2)
		{
			if (number1 < 0)
				number1 *= -1;

			while (number1 != 0 && number2 != 0)
			{
				if (number1 > number2)
					number1 %= number2;
				else
					number2 %= number1;
			}

			return number1 == 0 ? number2 : number1;
		}

		public static int ToInverseMember(this int originalMember)
		{
			int lengthOfAlphabet = CommonSettings.currentAlphabet.Count;
			return originalMember > 0 ? InverseForPositiveNumber(originalMember, lengthOfAlphabet) : InverseForNegativeNumber(originalMember, lengthOfAlphabet);
		}

		public static int RemainderAfterDivisionByAlphabetLength(this int originalNumber)
		{
			int lengthOfAlphabet = CommonSettings.currentAlphabet.Count;
			return (originalNumber > 0) ? originalNumber % lengthOfAlphabet : (originalNumber % lengthOfAlphabet) + lengthOfAlphabet;
		}

		public static bool RemainderEqualsZero(int number1, int number2) => number1 % number2 == 0;

		public static int ToModulo(this int number) => (number == 0) ? 0 : (number > 0) ? number % 26 : (number % 26) + 26;

		public static List<int> GetDivisors(int number, int rangeStart, int rangeEnd)
		{
			List<int> divisors = new List<int>();

			for (int i = rangeStart; i < rangeEnd + 1; i++)
				if (RemainderEqualsZero(number, i))
					divisors.Add(i);

			return divisors;
		}

		#endregion

		#region Private methods

		private static int InverseForPositiveNumber(int a, int n)
		{
			int i = n;
			int v = 0;
			int d = 1;

			while (a > 0)
			{
				int t = i / a, x = a;
				a = i % x;
				i = x;
				x = d;
				d = v - t * x;
				v = x;
			}
			v %= n;
			if (v < 0) v = (v + n) % n;
			return v;
		}

		private static int InverseForNegativeNumber(int x, int m) => (x % m + m) % m;

		#endregion
	}
}

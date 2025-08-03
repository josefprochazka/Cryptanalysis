using System;
using System.Collections.Generic;
using System.Linq;

namespace Cryptanalysis
{
	class RandomsOperations
	{
		#region Fields

		private static Random random = new Random();
		private static List<char> alphabet = CommonSettings.currentAlphabet;

		#endregion

		#region Public methods

		public static string GetRandomStringFromCurrentAlphabet(int lengthOfString)
		{
			string randomString = "";
			for (int i = 0; i < lengthOfString; i++)
				randomString += alphabet.ElementAt(random.Next(alphabet.Count()));
			return randomString;
		}

		public static int GetRandomNumber(int numberOfDigits) => (0 < numberOfDigits && numberOfDigits < 10) ? random.Next((int)Math.Pow(10, numberOfDigits - 1), (int)Math.Pow(10, numberOfDigits)) : -1;

		public static List<char> GetRandomCurrentAlphabetLettersList(int lengthOfString) => GetRandomStringFromCurrentAlphabet(lengthOfString).ToList();

		public static List<char> GetRandomAlphabetPermutation() => alphabet.OrderBy(a => Guid.NewGuid()).ToList();

		#endregion
	}
}
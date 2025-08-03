using System.Collections.Generic;
using System.Linq;

namespace Cryptanalysis
{
	public static class AlphabetOperations
	{
		#region Fields

		private static List<char> currentAlphabet = CommonSettings.currentAlphabet;

		#endregion

		#region Public methods

		public static char ToShiftedCharIfValid(this char originalLetter, int numberOfShift)
		{
			if (!originalLetter.IsLetter())
				return originalLetter;

			if (char.IsLower(originalLetter))
			{
				originalLetter = (char)(originalLetter + numberOfShift);
				if (originalLetter > 'z')
					originalLetter = (char)(originalLetter - 26);
				else if (originalLetter < 'a')
					originalLetter = (char)(originalLetter + 26);
			}

			if (char.IsUpper(originalLetter))
			{
				originalLetter = (char)(originalLetter + numberOfShift);
				if (originalLetter > 'Z')
					originalLetter = (char)(originalLetter - 26);
				else if (originalLetter < 'A')
					originalLetter = (char)(originalLetter + 26);
			}

			return originalLetter;
		}

		public static char ToLetter(this int number) => currentAlphabet.ElementAt(number);

		public static int ToNumber(this char letter) => currentAlphabet.IndexOf(letter.ToLower());

		public static List<int> ToNumbersOfLetters(this List<char> letterKey) => ListOperations.GetModifiedEachItemList<char, int>(letterKey, ToNumber);

		public static char ToReversedLetter(this char character) => ToLetter((currentAlphabet.Count - ToNumber(character)) % currentAlphabet.Count);

		public static List<char> ToReversedLetters(this List<char> letterFrequency) => ListOperations.GetModifiedEachItemList<char>(letterFrequency, ToReversedLetter);

		public static int ToReversedNumber(this int letterNumber) => currentAlphabet.Count - letterNumber;

		public static List<int> ToReversedNumbers(this List<int> numberSequence) => ListOperations.GetModifiedEachItemList<int>(numberSequence, ToReversedNumber);

		#endregion
	}
}
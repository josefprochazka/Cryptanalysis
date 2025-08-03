using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cryptanalysis
{
	public static class TextOperations
	{
		#region Public methods

		public static StringBuilder ToStringbuilder(this string value) => new StringBuilder(value);

		public static string TransferToString(this List<char> letterSequence) => string.Concat(letterSequence);

		public static StringBuilder ToStringbuilder(this List<char> letterSequence) => letterSequence.TransferToString().ToStringbuilder();

		public static char ToLower(this char ch) => char.ToLower(ch);

		public static char ToUpper(this char ch) => char.ToUpper(ch);

		public static int ToInteger(this string text) => int.Parse(text);

		public static StringBuilder GetModifiedEachItemText(this StringBuilder originalString, Func<char, char> modifyingMethod)
		{
			StringBuilder modifiedString = new StringBuilder();

			foreach (var ch in originalString.ToString())
				modifiedString.Append(modifyingMethod(ch));

			return modifiedString;
		}

		public static StringBuilder GetOnlyCharsAccordingToRegex(this StringBuilder text, string regex)
		{
			StringBuilder temp = new StringBuilder(text.Length);
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (Regex.IsMatch(c.ToString(), regex))
					temp.Append(c);
			}
			return temp;
		}

		public static StringBuilder GetOnlyValidChars(this StringBuilder text) => GetOnlyCharsAccordingToRegex(text, @"^[a-zA-Z]+$");

		public static string GetOnlyValidChars(this string text) => GetOnlyValidChars(text.ToStringbuilder()).ToString();

		public static StringBuilder GetOnlyNumbers(this StringBuilder text) => GetOnlyCharsAccordingToRegex(text, @"^[0-9]+$");

		public static string GetOnlyNumbers(this string text) => GetOnlyNumbers(text.ToStringbuilder()).ToString();

		public static List<char> RemoveDuplicates(this List<char> list) => new List<char>(new HashSet<char>(list));

		public static StringBuilder RemoveMarkingChar(this StringBuilder text) => new StringBuilder(text.ToString().Replace(CommonConstants.STAR_character.ToString(), ""));

		public static StringBuilder RemoveWhiteSpaces(this StringBuilder text) => new StringBuilder(text.ToString().Replace(" ", ""));

		public static string RemoveRecurringSubstrings(this string recurringText)
		{
			int[] divisors = MathematicalOperations.GetDivisors(recurringText.Length, 2, recurringText.Length / 2).ToArray();
			List<string> substrings = new List<string>();
			bool equality = true;
			string recurringSubstring = "";

			foreach (int divisor in divisors)
			{
				equality = true;
				substrings.Clear();

				for (int i = 0; i < recurringText.Length; i += divisor)
					substrings.Add(recurringText.Substring(i, divisor));

				for (int j = 0; j < substrings.Count - 1; j++)
				{
					if (substrings[j].CompareTo(substrings[j + 1]) != 0)
					{
						equality = false;
						break;
					}
				}

				if (equality)
				{
					recurringSubstring = recurringText.Substring(0, divisor);
					break;
				}
			}

			return (string.IsNullOrEmpty(recurringSubstring)) ? recurringText : recurringSubstring;
		}

		public static string RemoveSomeChars(this string originalText, char[] charsToRemove)
		{
			string modidifedText = "";
			foreach (var c in charsToRemove)
			{
				modidifedText = originalText.Replace(c.ToString(), "");
				originalText = modidifedText;
			}
			return (modidifedText.IsEmpty()) ? originalText : modidifedText;
		}

		public static string ExceptChars(this string text, IEnumerable<char> toExclude) => ExceptChars(text.ToStringbuilder(), toExclude).ToString();

		public static StringBuilder ExceptChars(this StringBuilder text, IEnumerable<char> toExclude)
		{
			StringBuilder temp = new StringBuilder(text.Length);
			for (int i = 0; i < text.Length; i++)
			{
				char c = text[i];
				if (!toExclude.Contains(c))
					temp.Append(c);
			}
			return temp;
		}

		public static StringBuilder PutNonValidCharsIntoTextAccordingToOtherText(StringBuilder originalText, StringBuilder otherText)
		{
			StringBuilder modifiedText = new StringBuilder();
			int counter = 0;
			int longerTextLength = (originalText.Length > otherText.Length) ? originalText.Length : otherText.Length;

			for (int i = 0; i < longerTextLength; i++)
				if (i < otherText.Length)
					modifiedText.Append((!otherText[i].IsLetter()) ? otherText[i] : originalText[counter++]);

			return modifiedText;
		}

		public static string ToCapitalsWithSpaces(this string text) => new Regex("[^a-zA-Z ]").Replace(text, "").ToUpper();

		public static string ToCapitalsWithoutSpaces(this string text) => new Regex("[^a-zA-Z]").Replace(text, "").ToUpper();

		public static string LowerLettersWithSpaces(this string text) => new Regex("[^a-zA-Z ]").Replace(text, "").ToLower();

		public static string LowerLettersWithoutSpaces(this string text) => new Regex("[^a-zA-Z]").Replace(text, "").ToLower();

		public static StringBuilder LowerLettersWithoutSpaces(this StringBuilder text) => LowerLettersWithoutSpaces(text.ToString()).ToStringbuilder();

		public static bool IsLetter(this char originalLetter) => Regex.IsMatch(originalLetter.ToString(), @"^[a-zA-Z]+$");

		public static bool ContainsDigitsOnly(this string str)
		{
			foreach (char c in str)
				if (c < '0' || c > '9')
					return false;

			return true;
		}

		public static bool ContainsLettersOnly(this string str)
		{
			return Regex.IsMatch(str, @"^[a-zA-Z]+$");
		}

		public static bool IsNumberInRange(this int number, int rangeMin, int rangeMax)
		{
			for (int i = rangeMin; i <= rangeMax; i++)
			{
				if (number == i)
					return true;
			}
			return false;
		}

		public static bool IsEmpty(this string text) => (string.IsNullOrEmpty(text));


		#endregion
	}
}
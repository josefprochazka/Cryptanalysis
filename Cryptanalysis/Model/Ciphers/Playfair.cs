using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cryptanalysis
{
	internal class Playfair : AbstractCiphers, IEncryption
	{

		#region Fields

		private CipherTable keyTable;
		private List<char> currentAlphabetWithoutJ;
		private Coordinates firstLetter;
		private Coordinates secondLetter;
		private string letterPartKey;
		private string alphabetPartKey;
		private char letterX = CommonSettings.CurrentLetterX;
		private char letterY = CommonSettings.CurrentLetterY;
		private char letterJ = CommonSettings.CurrentLetterJ;

		#endregion

		#region Constructors

		public Playfair()
		{
			plainTextValidChars = new StringBuilder();
			cipherTextValidChars = new StringBuilder();
			keyTable = (CommonSettings.currentAlphabet.Count == 26) ? new CipherTable(5, 5) : new CipherTable(5, 8);
			currentAlphabetWithoutJ = new List<char>(CommonSettings.currentAlphabet);
			currentAlphabetWithoutJ.Remove(letterJ);
		}

		#endregion

		#region Public methods

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			plainText = plainText.LowerLettersWithoutSpaces();
			plainText.Replace(letterJ, CommonSettings.CurrentLetterI);
			PutXBetweenIdenticalLetters(ref plainText);
			if (plainText.Length % 2 == 1)
				plainText.Append((plainText[plainText.Length - 1] == letterX) ? letterY : letterX);

			keyTable.FillTableByRows(GetKeyAndAlphabetJoined(key).ToStringbuilder());

			for (int i = 0; i < plainText.Length; i += 2)
			{
				firstLetter = keyTable.GetTableCoordinatesOfCharacter(plainText[i]);
				secondLetter = keyTable.GetTableCoordinatesOfCharacter(plainText[i + 1]);

				if (firstLetter.Row == secondLetter.Row)
				{
					EncryptSameRowLetters(cipherTextValidChars, firstLetter, keyTable);
					EncryptSameRowLetters(cipherTextValidChars, secondLetter, keyTable);
				}
				else if (firstLetter.Column == secondLetter.Column)
				{
					EncryptSameColumnLetters(cipherTextValidChars, firstLetter, keyTable);
					EncryptSameColumnLetters(cipherTextValidChars, secondLetter, keyTable);
				}
				else
				{
					cipherTextValidChars.Append(keyTable.GetCell(secondLetter.Column, firstLetter.Row));
					cipherTextValidChars.Append(keyTable.GetCell(firstLetter.Column, secondLetter.Row));
				}
			}

			return cipherTextValidChars;
		}

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			cipherText = cipherText.LowerLettersWithoutSpaces();

			keyTable.FillTableByRows(GetKeyAndAlphabetJoined(key).ToStringbuilder());

			for (int i = 0; i < cipherText.Length; i += 2)
			{
				firstLetter = keyTable.GetTableCoordinatesOfCharacter(cipherText[i]);
				secondLetter = keyTable.GetTableCoordinatesOfCharacter(cipherText[i + 1]);

				if (firstLetter.Row == secondLetter.Row)
				{
					DecryptSameRowLetters(plainTextValidChars, firstLetter, keyTable);
					DecryptSameRowLetters(plainTextValidChars, secondLetter, keyTable);
				}
				else if (firstLetter.Column == secondLetter.Column)
				{
					DecryptSameColumnLetters(plainTextValidChars, firstLetter, keyTable);
					DecryptSameColumnLetters(plainTextValidChars, secondLetter, keyTable);
				}
				else
				{
					plainTextValidChars.Append(keyTable.GetCell(secondLetter.Column, firstLetter.Row));
					plainTextValidChars.Append(keyTable.GetCell(firstLetter.Column, secondLetter.Row));
				}
			}

			return plainTextValidChars;
		}

		public string GetKeyAndAlphabetJoined(Key key)
		{
			letterPartKey = string.Concat(key.LetterSequence);
			letterPartKey = string.Join("", letterPartKey.Distinct());
			letterPartKey = letterPartKey.Replace(letterJ.ToString(), "");
			alphabetPartKey = string.Concat(currentAlphabetWithoutJ);
			alphabetPartKey = alphabetPartKey.ExceptChars(letterPartKey.ToArray());
			key.LetterSequence = (letterPartKey + alphabetPartKey).ToList();
			return letterPartKey + alphabetPartKey;
		}

		#endregion

		#region Private methods

		private void DecryptSameColumnLetters(StringBuilder plainText, Coordinates letter, CipherTable keyTable)
		{
			plainText.Append((letter.Row == 0) ?
					keyTable.GetCell(letter.Column, keyTable.RowCount - 1) :
					keyTable.GetCell(letter.Column, letter.Row - 1));
		}

		private void DecryptSameRowLetters(StringBuilder plainText, Coordinates letter, CipherTable keyTable)
		{
			plainText.Append((letter.Column == 0) ?
				keyTable.GetCell(keyTable.ColumnCount - 1, letter.Row) :
				keyTable.GetCell(letter.Column - 1, letter.Row));
		}

		private void EncryptSameColumnLetters(StringBuilder cipherText, Coordinates letter, CipherTable keyTable)
		{
			cipherText.Append((letter.Row == keyTable.RowCount - 1) ?
					keyTable.GetCell(letter.Column, 0) :
					keyTable.GetCell(letter.Column, letter.Row + 1));
		}

		private void EncryptSameRowLetters(StringBuilder cipherText, Coordinates letter, CipherTable keyTable)
		{
			cipherText.Append((letter.Column == keyTable.ColumnCount - 1) ?
					keyTable.GetCell(0, letter.Row) :
					keyTable.GetCell(letter.Column + 1, letter.Row));
		}

		private void PutXBetweenIdenticalLetters(ref StringBuilder originalText)
		{
			StringBuilder correctText = new StringBuilder();

			for (int i = 0; i < originalText.Length; i++)
			{
				if (i == originalText.Length - 1)
				{
					correctText.Append(originalText[i]);
					break;
				}

				correctText.Append(originalText[i]);

				if (originalText[i] == originalText[i + 1])
					correctText.Append((originalText[i] == letterX) ? letterY : letterX);
				else
					correctText.Append(originalText[i++ + 1]);
			}

			originalText = new StringBuilder().Append(correctText);
		}

		#endregion
	}
}
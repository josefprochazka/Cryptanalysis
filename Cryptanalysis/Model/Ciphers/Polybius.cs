using System.Collections.Generic;
using System.Text;

namespace Cryptanalysis
{
	internal class Polybius : AbstractCiphers, IEncryption
	{
		#region Fields

		private CipherTable alphabetTable;
		private List<char> currentAlphabetWithoutJ;
		private Coordinates letterTempCoordinates;

		#endregion

		#region Constructors

		public Polybius()
		{
			cipherTextValidChars = new StringBuilder();
			plainTextValidChars = new StringBuilder();
			alphabetTable = (CommonSettings.currentAlphabet.Count == 26) ? new CipherTable(5, 5) : new CipherTable(5, 8);
			currentAlphabetWithoutJ = new List<char>(CommonSettings.currentAlphabet);
			currentAlphabetWithoutJ.Remove(CommonSettings.CurrentLetterJ);
			alphabetTable.FillTableByRows(currentAlphabetWithoutJ.ToStringbuilder());
			letterTempCoordinates = new Coordinates();
		}

		#endregion

		#region Public methods

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key = null)
		{
			plainText = plainText.LowerLettersWithoutSpaces();
			plainText.Replace(CommonSettings.CurrentLetterJ, CommonSettings.CurrentLetterI);
			foreach (var letter in plainText.ToString())
			{
				letterTempCoordinates = alphabetTable.GetTableCoordinatesOfCharacter(letter);
				cipherTextValidChars.Append(
					letterTempCoordinates.Row.ToLetter().ToString() +
					letterTempCoordinates.Column.ToLetter().ToString());
			}

			return cipherTextValidChars;
		}

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key = null)
		{
			cipherText = cipherText.LowerLettersWithoutSpaces();

			for (int i = 0; i < cipherText.Length; i += 2)
			{
				letterTempCoordinates.Row = cipherText[i].ToNumber();
				letterTempCoordinates.Column = cipherText[i + 1].ToNumber();
				plainTextValidChars.Append(alphabetTable.GetCell(letterTempCoordinates.Column, letterTempCoordinates.Row));
			}

			return plainTextValidChars;
		}

		#endregion
	}
}
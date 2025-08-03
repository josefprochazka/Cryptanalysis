using System.Text;

namespace Cryptanalysis
{
	internal class Hill : AbstractCiphers, IEncryption
	{
		#region Fields

		private CipherTable plainTextTable;
		private CipherTable cipherTextTable;
		private CipherTable keyTable;
		private int[,] keyInversionTable;
		private int determinant;
		private int determinantInverse;
		private char testLetter;

		#endregion

		#region Constructors

		public Hill()
		{
			keyTable = new CipherTable(2, 2);
			keyInversionTable = new int[2, 2];
		}

		#endregion

		#region Public methods

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			plainTextValidChars = plainText.GetOnlyValidChars();

			if (plainTextValidChars.Length % 2 == 1)
			{
				plainTextValidChars.Append(CommonSettings.CurrentLetterQ.ToString());
				plainText.Append(CommonSettings.CurrentLetterQ.ToString());
			}

			plainTextTable = new CipherTable(plainTextValidChars.Length / 2, 2);
			cipherTextTable = new CipherTable(plainTextValidChars.Length / 2, 2);

			key.CreateNumberKeyFromLetterKey();
			keyTable.FillTableByRows(key.LetterSequence.ToStringbuilder());
			plainTextTable.FillTableByColumns(plainTextValidChars);

			for (int i = 0; i < plainTextTable.ColumnCount; i++)
				for (int j = 0; j < 2; j++)
				{
					testLetter = plainTextTable.GetCell(i, j);
					encryptedLetter = (
						keyTable.GetCell(0, j).ToNumber() * plainTextTable.GetCell(i, 0).ToLower().ToNumber() +
						keyTable.GetCell(1, j).ToNumber() * plainTextTable.GetCell(i, 1).ToLower().ToNumber())
						.ToModulo()
						.ToLetter();
					cipherTextTable.SetCell(i, j, (char.IsLower(plainTextTable.GetCell(i, j)) ? encryptedLetter : encryptedLetter.ToUpper()));
				}

			return TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(cipherTextTable.ReadTableByColumns(), plainText);
		}

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			cipherTextValidChars = cipherText.GetOnlyValidChars();

			cipherTextTable = new CipherTable(cipherTextValidChars.Length / 2, 2);
			plainTextTable = new CipherTable(cipherTextValidChars.Length / 2, 2);

			key.CreateNumberKeyFromLetterKey();
			determinant = key.NumberSequence[0] * key.NumberSequence[3] - key.NumberSequence[1] * key.NumberSequence[2];
			determinantInverse = determinant.ToInverseMember();
			keyTable.FillTableByRows(key.LetterSequence.ToStringbuilder());
			cipherTextTable.FillTableByColumns(cipherTextValidChars);

			keyInversionTable[0, 0] = (keyTable.GetCell(1, 1).ToNumber() * determinantInverse).ToModulo();
			keyInversionTable[1, 0] = (keyTable.GetCell(1, 0).ToNumber() * (-1) * determinantInverse).ToModulo();
			keyInversionTable[0, 1] = (keyTable.GetCell(0, 1).ToNumber() * (-1) * determinantInverse).ToModulo();
			keyInversionTable[1, 1] = (keyTable.GetCell(0, 0).ToNumber() * determinantInverse).ToModulo();

			for (int i = 0; i < cipherTextTable.ColumnCount; i++)
				for (int j = 0; j < 2; j++)
				{
					testLetter = cipherTextTable.GetCell(i, j);
					decryptedLetter = (
						keyInversionTable[0, j] * cipherTextTable.GetCell(i, 0).ToLower().ToNumber() +
						keyInversionTable[1, j] * cipherTextTable.GetCell(i, 1).ToLower().ToNumber())
						.ToModulo()
						.ToLetter();
					plainTextTable.SetCell(i, j, (char.IsLower(cipherTextTable.GetCell(i, j)) ? decryptedLetter : decryptedLetter.ToUpper()));
				}

			return TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(plainTextTable.ReadTableByColumns(), cipherText);
		}

		#endregion
	}
}
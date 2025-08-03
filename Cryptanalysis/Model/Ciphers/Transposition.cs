using System;
using System.Linq;
using System.Text;

namespace Cryptanalysis
{
	internal class Transposition : AbstractCiphers, IEncryption
	{
		#region Fields

		private int addedRowCount = 0;
		private TranspositionType transpositionType;
		private TableType tableType;
		private CipherTable transposedTable;
		private int[] decipherNumberKey;
		private Func<int, int, bool> NullReminder = MathematicalOperations.RemainderEqualsZero;

		#endregion

		#region Constructors

		public Transposition(TranspositionType transpositionType, TableType tableType)
		{
			this.transpositionType = transpositionType;
			this.tableType = tableType;
		}

		#endregion

		#region Public methods

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			key.LetterSequence = key.LetterSequence.RemoveDuplicates();
			plainTextValidChars = plainText.GetOnlyValidChars();
			if (!NullReminder(plainTextValidChars.Length, key.LetterSequence.Count))
			{
				if (tableType == TableType.Complete)
					plainTextValidChars.Append(RandomsOperations.GetRandomStringFromCurrentAlphabet(key.LetterSequence.Count - plainTextValidChars.Length % key.LetterSequence.Count));
				else
					addedRowCount = 1;
			}
			encryptingTable = new CipherTable(key.LetterSequence.Count, (plainTextValidChars.Length / key.LetterSequence.Count) + addedRowCount);

			encryptingTable.FillTableByRows(plainTextValidChars);
			key.CreateKeyForTranspositionCipher();
			transposedTable = encryptingTable.GetTransposedColumnsTable(key);
			transposedText = (transpositionType == TranspositionType.Row) ? transposedTable.GetTableTextReadByRows() : transposedTable.GetTableTextReadByColumns(CommonConstants.STAR_character);
			finalText = (tableType == TableType.Complete) ? transposedText.RemoveMarkingChar() : transposedText.RemoveWhiteSpaces();
			return (tableType == TableType.Irregular) ? TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(finalText, plainText) : finalText;
		}

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			key.LetterSequence = key.LetterSequence.RemoveDuplicates();
			addedRowCount = 0;
			cipherTextValidChars = cipherText.GetOnlyValidChars();
			if (!NullReminder(cipherTextValidChars.Length, key.LetterSequence.Count) && tableType == TableType.Irregular)
				addedRowCount = 1;
			decryptingTable = new CipherTable(key.LetterSequence.Count, (cipherTextValidChars.Length / key.LetterSequence.Count) + addedRowCount);

			key.CreateKeyForTranspositionCipher();
			ChangeToDecipherKey(key);
			if (tableType == TableType.Irregular)
				decryptingTable.PutSpecialCharsInBottomLineEmptySpaces(cipherTextValidChars, key);

			if (transpositionType == TranspositionType.Row)
				decryptingTable.FillTableByRowsIgnoreSomeChar(cipherTextValidChars, CommonConstants.STAR_character);
			else
				decryptingTable.FillTableByColumnsIgnoreSomeChar(cipherTextValidChars, CommonConstants.STAR_character);

			transposedTable = decryptingTable.GetTransposedColumnsTable(key);
			transposedText = transposedTable.GetTableTextReadByRows();
			finalText = transposedText.RemoveMarkingChar();
			return (tableType == TableType.Irregular) ? TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(finalText, cipherText) : finalText;
		}

		#endregion

		#region Private methods

		private void ChangeToDecipherKey(Key key)
		{
			decipherNumberKey = new int[key.TranspositionNumberSequence.Count];

			for (int i = 0; i < key.TranspositionNumberSequence.Count; i++)
				decipherNumberKey[key.TranspositionNumberSequence.ElementAt(i)] = i;

			key.TranspositionNumberSequence = decipherNumberKey.ToList();
		}

		#endregion
	}
}
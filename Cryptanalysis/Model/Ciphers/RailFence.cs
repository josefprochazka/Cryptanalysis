using System.Text;

namespace Cryptanalysis
{
	internal class RailFence : AbstractCiphers, IEncryption
	{
		#region Fields

		private int rowCounter;
		private int directionChanger;
		private StringBuilder tempText;

		#endregion

		#region Public methods

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			plainTextValidChars = plainText.GetOnlyValidChars();
			encryptingTable = new CipherTable(plainTextValidChars.Length, key.SingleNumber);
			GoThroughTableByZigZagWayAndDoAction(encryptingTable, plainTextValidChars, key.SingleNumber, TableAction.FillTableByText);
			return TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(encryptingTable.GetTableTextReadByRows(' '), plainText);
		}

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			cipherTextValidChars = cipherText.GetOnlyValidChars();
			decryptingTable = new CipherTable(cipherTextValidChars.Length, key.SingleNumber);
			GoThroughTableByZigZagWayAndDoAction(decryptingTable, cipherTextValidChars, key.SingleNumber, TableAction.FillTableByText);
			decryptingTable.FillTableByRowsIgnoreSomeCharacter(cipherTextValidChars, ' ');
			return TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(GoThroughTableByZigZagWayAndDoAction(decryptingTable, cipherTextValidChars, key.SingleNumber, TableAction.FillTextByTable), cipherText);
		}

		#endregion

		#region Private methods

		private StringBuilder GoThroughTableByZigZagWayAndDoAction(CipherTable table, StringBuilder text, int rowCount, TableAction action)
		{
			tempText = new StringBuilder();
			rowCounter = 0;
			directionChanger = 1;

			for (int i = 0; i < text.Length; i++)
			{
				if (action == TableAction.FillTableByText)
					table.SetCell(i, rowCounter, text[i]);
				else if (action == TableAction.FillTextByTable)
					tempText.Append(table.GetCell(i, rowCounter));

				rowCounter += directionChanger;
				directionChanger *= (rowCounter == rowCount - 1 || rowCounter == 0) ? -1 : 1;
			}

			return tempText;
		}

		#endregion
	}
}
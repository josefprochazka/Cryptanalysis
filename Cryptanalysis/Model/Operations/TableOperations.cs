using System.Text;

namespace Cryptanalysis
{
	public static class TableOperations
	{
		#region Fields

		private static int counter;
		private static StringBuilder tempText;

		#endregion

		#region Public methods

		public static StringBuilder ReadTableByRows(this CipherTable table)
		{
			tempText = new StringBuilder();

			for (int i = 0; i < table.RowCount; i++)
				for (int j = 0; j < table.ColumnCount; j++)
					tempText.Append((table.GetCell(j, i)));

			return tempText;
		}

		public static StringBuilder ReadTableByColumns(this CipherTable table)
		{
			tempText = new StringBuilder();

			for (int i = 0; i < table.ColumnCount; i++)
				for (int j = 0; j < table.RowCount; j++)
					tempText.Append((table.GetCell(i, j)));

			return tempText;
		}

		public static StringBuilder ReadTableRowsIgnoreSomeChar(this CipherTable table, char ignoringChar)
		{
			tempText = new StringBuilder();

			for (int i = 0; i < table.RowCount; i++)
				for (int j = 0; j < table.ColumnCount; j++)
					if (table.GetCell(j, i) != ignoringChar)
						tempText.Append((table.GetCell(j, i)));

			return tempText;
		}

		public static StringBuilder ReadTableColumnsIgnoreSomeChar(this CipherTable table, char ignoringChar)
		{
			tempText = new StringBuilder();

			for (int i = 0; i < table.ColumnCount; i++)
				for (int j = 0; j < table.RowCount; j++)
					if (table.GetCell(i, j) != ignoringChar)
						tempText.Append((table.GetCell(i, j)));

			return tempText;
		}

		public static void FillTableRows(this CipherTable table, StringBuilder text)
		{
			counter = 0;

			for (int i = 0; i < table.RowCount; i++)
				for (int j = 0; j < table.ColumnCount; j++)
				{
					if (counter == text.Length)
						break;
					table.SetCell(j, i, text[counter++]);
				}
		}

		public static void FillTableColumns(this CipherTable table, StringBuilder text)
		{
			counter = 0;

			for (int i = 0; i < table.ColumnCount; i++)
				for (int j = 0; j < table.RowCount; j++)
				{
					if (counter == text.Length)
						break;
					table.SetCell(i, j, text[counter++]);
				}
		}

		public static void FillTableByRowsIgnoreSomeCharacter(this CipherTable table, StringBuilder text, char ignoringChar)
		{
			counter = 0;

			for (int i = 0; i < table.RowCount; i++)
				for (int j = 0; j < table.ColumnCount; j++)
					if (table.GetCell(j, i) != ignoringChar)
						table.SetCell(j, i, text[counter++]);
		}

		public static void FillTableByColumnsIgnoreSomeCharacter(this CipherTable table, StringBuilder text, char ignoringChar)
		{
			counter = 0;

			for (int i = 0; i < table.ColumnCount; i++)
				for (int j = 0; j < table.RowCount; j++)
					if (table.GetCell(i, j) != ignoringChar)
						table.SetCell(i, j, text[counter++]);
		}

		public static char[,] FillTableWithCharacter(this CipherTable table, char fillingChar)
		{
			for (int i = 0; i < table.RowCount; i++)
				for (int j = 0; j < table.ColumnCount; j++)
					table.Table[j, i] = fillingChar;

			return table.Table;
		}

		public static void PutSpecialCharsInBottomLineEmptySpaces(this CipherTable decryptingTable, StringBuilder cipherText, Key key)
		{
			if (MathematicalOperations.RemainderEqualsZero(cipherText.Length, key.LetterSequence.Count))
				return;

			int markedCellsCount = key.TranspositionNumberSequence.Count - (cipherText.Length % key.TranspositionNumberSequence.Count);
			int highestKeyNumber = key.TranspositionNumberSequence.Count - 1;

			for (int i = 0; i < markedCellsCount; i++)
				for (int j = 0; j < key.LetterSequence.Count; j++)
					if (key.TranspositionNumberSequence[j] == highestKeyNumber)
					{
						decryptingTable.SetCell(j, decryptingTable.RowCount - 1, CommonConstants.STAR_character);
						highestKeyNumber--;
						break;
					}
		}

		#endregion
	}
}
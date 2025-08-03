using System.Text;

namespace Cryptanalysis
{
	public class CipherTable
	{
		#region Fields

		private CipherTable transposedTable;
		private int originalColumnNumber;

		#endregion

		#region Constructors

		public CipherTable(int columnCount, int rowCount)
		{
			ColumnCount = columnCount;
			RowCount = rowCount;
			Table = new char[columnCount, rowCount];
			FillTableByEmptySpaces();
		}

		#endregion

		#region Properties

		public char[,] Table { get; set; }

		public int ColumnCount { get; set; }

		public int RowCount { get; set; }

		#endregion

		#region Public methods

		public void SetCell(int columnIndex, int rowIndex, char character) => Table[columnIndex, rowIndex] = character;

		public char GetCell(int columnIndex, int rowIndex) => Table[columnIndex, rowIndex];

		public StringBuilder GetTableTextReadByRows() => this.ReadTableByRows();

		public StringBuilder GetTableTextReadByRows(char ignoringChar) => this.ReadTableRowsIgnoreSomeChar(ignoringChar);

		public StringBuilder GetTableTextReadByColumns(char ignoringChar) => this.ReadTableColumnsIgnoreSomeChar(ignoringChar);

		public void FillTableByRows(StringBuilder text) => this.FillTableRows(text);

		public void FillTableByRowsIgnoreSomeChar(StringBuilder text, char ignoringChar) => this.FillTableByRowsIgnoreSomeCharacter(text, ignoringChar);

		public void FillTableByColumnsIgnoreSomeChar(StringBuilder cipherText, char ignoringChar) => this.FillTableByColumnsIgnoreSomeCharacter(cipherText, ignoringChar);

		public void FillTableByColumns(StringBuilder text) => this.FillTableColumns(text);

		public char GetCharacterOfTableCoordinates(Coordinates characterCoordinates) => GetCell(characterCoordinates.Column, characterCoordinates.Row);

		public CipherTable GetTransposedColumnsTable(Key key)
		{
			transposedTable = new CipherTable(ColumnCount, RowCount);
			originalColumnNumber = 0;

			foreach (var transposedColumnNumber in key.TranspositionNumberSequence)
			{
				for (int rowNumber = 0; rowNumber < RowCount; rowNumber++)
					transposedTable.SetCell(transposedColumnNumber, rowNumber, this.GetCell(originalColumnNumber, rowNumber));
				originalColumnNumber++;
			}

			return transposedTable;
		}

		public Coordinates GetTableCoordinatesOfCharacter(char searchedCharacter)
		{
			for (int row = 0; row < RowCount; row++)
			{
				for (int column = 0; column < ColumnCount; column++)
				{
					if (GetCell(column, row) == searchedCharacter)
						return new Coordinates() { Row = row, Column = column };
				}
			}
			return null;
		}

		#endregion

		#region Private methods

		private void FillTableByEmptySpaces() => this.FillTableWithCharacter(' ');

		#endregion
	}

	#region Other classes

	public class Coordinates
	{
		public int Row { get; set; }

		public int Column { get; set; }
	}

	#endregion
}

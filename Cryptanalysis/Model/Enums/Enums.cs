namespace Cryptanalysis
{
	public enum TranspositionType
	{
		Row,
		Columnar
	}

	public enum TableType
	{
		Complete,
		Irregular
	}

	public enum CurrentAlphabet
	{
		ENG,
		eng
	}

	public enum TableAction
	{
		FillTableByText,
		FillTextByTable
	}

	public enum CryptanalysisMeasureType
	{
		Fitness,
		ChiSquare
	}

	public enum KeyType
	{
		Number,
		TwoNumbers,
		Sequence,
		TwoSequencies
	}
}

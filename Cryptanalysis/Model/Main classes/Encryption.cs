namespace Cryptanalysis
{
	public class Encryption
	{
		#region Fields

		private static IEncryption currentCipher;

		#endregion

		#region Public methods

		public static string GetEncryptedTextByCaesarCipher(string plainText, Key key)
		{
			currentCipher = new Caesar();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByPlayfairCipher(string plainText, Key key)
		{
			currentCipher = new Playfair();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByHillCipher(string plainText, Key key)
		{
			currentCipher = new Hill();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByPolybiusCipher(string plainText, Key key)
		{
			currentCipher = new Polybius();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByRowTranspositionCipher(string plainText, Key key, bool incompleteTable)
		{
			currentCipher = new Transposition(TranspositionType.Row, (incompleteTable) ? TableType.Irregular : TableType.Complete);
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByColumnTranspositionCipher(string plainText, Key key, bool incompleteTable)
		{
			currentCipher = new Transposition(TranspositionType.Columnar, (incompleteTable) ? TableType.Irregular : TableType.Complete);
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByRailFenceCipher(string plainText, Key key)
		{
			currentCipher = new RailFence();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByVigenereCipher(string plainText, Key key)
		{
			currentCipher = new Vigenere();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextBySubstitutionCipher(string plainText, Key key)
		{
			currentCipher = new Substitution();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByAffineCipher(string plainText, Key key)
		{
			currentCipher = new Affine();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByVernamCipher(string plainText, Key key)
		{
			key.NumberSequence = key.LetterSequence.ToNumbersOfLetters();
			currentCipher = new Vernam();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		public static string GetEncryptedTextByDoubleTranspositionCipher(string plainText, Key key)
		{
			currentCipher = new DoubleTransposition();
			return currentCipher.GetEncryptedText(plainText.ToStringbuilder(), key).ToString();
		}

		#endregion
	}
}
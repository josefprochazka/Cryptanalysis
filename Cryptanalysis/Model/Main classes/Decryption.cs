namespace Cryptanalysis
{
	public class Decryption
	{
		#region Fields

		private static IEncryption currentCipher;

		#endregion

		#region Public methods

		public static string GetDecryptedTextByCaesarCipher(string cipherText, Key key)
		{
			currentCipher = new Caesar();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByPolybiusCipher(string cipherText, Key key)
		{
			currentCipher = new Polybius();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString().ToUpper();
		}

		public static string GetDecryptedTextByPlayfairCipher(string cipherText, Key key)
		{
			currentCipher = new Playfair();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString().ToUpper();
		}

		public static string GetDecryptedTextByHillCipher(string cipherText, Key key)
		{
			currentCipher = new Hill();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByVernamCipher(string cipherText, Key key)
		{
			currentCipher = new Vernam();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByRowTranspositionCipher(string cipherText, Key key, bool incompleteTable)
		{
			currentCipher = new Transposition(TranspositionType.Row, (incompleteTable) ? TableType.Irregular : TableType.Complete);
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByColumnTranspositionCipher(string cipherText, Key key, bool incompleteTable)
		{
			currentCipher = new Transposition(TranspositionType.Columnar, (incompleteTable) ? TableType.Irregular : TableType.Complete);
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByRailFenceCipher(string cipherText, Key key)
		{
			// key.SingleNumber must be at least as long as cipherText
			currentCipher = new RailFence();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByVigenereCipher(string cipherText, Key key)
		{
			currentCipher = new Vigenere();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextBySubstitutionCipher(string cipherText, Key key)
		{
			currentCipher = new Substitution();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByAffineCipher(string cipherText, Key key)
		{
			currentCipher = new Affine();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		public static string GetDecryptedTextByDoubleTranspositionCipher(string cipherText, Key key)
		{
			currentCipher = new DoubleTransposition();
			return currentCipher.GetDecryptedText(cipherText.ToStringbuilder(), key).ToString();
		}

		#endregion
	}
}
using System.Text;

namespace Cryptanalysis
{
	class DoubleTransposition : AbstractCiphers, IEncryption
	{
		#region Fields

		private Transposition transpositionCipher = new Transposition(TranspositionType.Columnar, TableType.Irregular);

		#endregion

		#region Public methods

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			transposedText = transpositionCipher.GetEncryptedText(plainText, new Key() { LetterSequence = key.DoubleTranspositionKey.Key1 });
			finalText = transpositionCipher.GetEncryptedText(transposedText, new Key() { LetterSequence = key.DoubleTranspositionKey.Key2 });
			return finalText;
		}

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			transposedText = transpositionCipher.GetDecryptedText(cipherText, new Key() { LetterSequence = key.DoubleTranspositionKey.Key2 });
			finalText = transpositionCipher.GetDecryptedText(transposedText, new Key() { LetterSequence = key.DoubleTranspositionKey.Key1 });
			return finalText;
		}

		#endregion
	}
}
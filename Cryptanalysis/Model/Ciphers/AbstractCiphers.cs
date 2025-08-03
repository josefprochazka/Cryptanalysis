using System.Text;

namespace Cryptanalysis
{
	public abstract class AbstractCiphers
	{
		#region Fields

		protected Key cipherKey = new Key();
		protected Key decipherKey = new Key();
		protected int encryptedLetterNumber;
		protected int decryptedLetterNumber;
		protected char encryptedLetter;
		protected char decryptedLetter;
		protected StringBuilder transposedText = new StringBuilder();
		protected StringBuilder finalText = new StringBuilder();
		protected CipherTable encryptingTable;
		protected CipherTable decryptingTable;
		protected StringBuilder plainTextValidChars;
		protected StringBuilder cipherTextValidChars;

		#endregion
	}
}
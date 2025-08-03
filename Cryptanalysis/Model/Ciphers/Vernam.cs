using System.Text;

namespace Cryptanalysis
{
	class Vernam : AbstractCiphers, IEncryption
	{
		#region Fields

		private int counter;

		#endregion

		#region Public methods

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			decipherKey.NumberSequence = key.NumberSequence.ToReversedNumbers();
			return GetEncryptedText(cipherText, decipherKey);
		}

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			cipherKey = key;
			counter = 0;
			return plainText.GetModifiedEachItemText(GetEncryptedCharIfValid);
		}

		#endregion

		#region Private methods

		private char GetEncryptedCharIfValid(char originalLetter) => originalLetter.ToShiftedCharIfValid(cipherKey.NumberSequence[counter++]);

		#endregion
	}
}

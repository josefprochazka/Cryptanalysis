using System.Text;

namespace Cryptanalysis
{
	public class Caesar : AbstractCiphers, IEncryption
	{
		#region Public methods

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			decipherKey.SingleNumber = key.SingleNumber.ToReversedNumber();
			return GetEncryptedText(cipherText, decipherKey);
		}

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			cipherKey.SingleNumber = key.SingleNumber;
			return plainText.GetModifiedEachItemText(GetEncryptedCharIfValid);
		}

		#endregion

		#region Private methods

		private char GetEncryptedCharIfValid(char originalLetter) => originalLetter.ToShiftedCharIfValid(cipherKey.SingleNumber);

		#endregion
	}
}
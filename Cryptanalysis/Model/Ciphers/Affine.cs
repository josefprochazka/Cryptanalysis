using System;
using System.Text;

namespace Cryptanalysis
{
	internal class Affine : AbstractCiphers, IEncryption
	{
		#region Fields

		public Func<int, int> Reminder = MathematicalOperations.RemainderAfterDivisionByAlphabetLength;

		#endregion

		#region Public methods

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			key.AffineKey.InverseOfA = key.AffineKey.A.ToInverseMember();
			decipherKey = key;
			return cipherText.GetModifiedEachItemText(GetDecryptedCharIfValid);
		}

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			cipherKey = key;
			return plainText.GetModifiedEachItemText(GetEncryptedCharIfValid);
		}

		#endregion

		#region Private methods

		private char GetEncryptedCharIfValid(char originalLetter)
		{
			if (originalLetter.IsLetter())
			{
				encryptedLetterNumber = (cipherKey.AffineKey.A * originalLetter.ToLower().ToNumber() + cipherKey.AffineKey.B) % cipherKey.AffineKey.M;
				encryptedLetter = encryptedLetterNumber.ToLetter();
				return (char.IsLower(originalLetter)) ? encryptedLetter : char.ToUpper(encryptedLetter);
			}
			else
				return originalLetter;
		}

		private char GetDecryptedCharIfValid(char originalLetter)
		{
			if (originalLetter.IsLetter())
			{
				decryptedLetterNumber = Reminder((Reminder(originalLetter.ToLower().ToNumber() - decipherKey.AffineKey.B)) * decipherKey.AffineKey.InverseOfA);
				decryptedLetter = decryptedLetterNumber.ToLetter();
				return (char.IsLower(originalLetter)) ? decryptedLetter : char.ToUpper(decryptedLetter);
			}
			else
				return originalLetter;
		}

		#endregion
	}
}
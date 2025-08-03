using System;
using System.Linq;
using System.Text;

namespace Cryptanalysis
{
	public class Substitution : AbstractCiphers, IEncryption
	{
		#region Public methods

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			cipherKey = key;
			return plainText.GetModifiedEachItemText(GetEncryptedCharIfValid);
		}

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			decipherKey = key;
			return cipherText.GetModifiedEachItemText(GetDecryptedCharIfValid);
		}

		public StringBuilder GetDecryptedTextIfKeyCharExists(StringBuilder cipherText, Key key)
		{
			cipherKey = key;
			return cipherText.GetModifiedEachItemText(GetDecryptedCharIfValidAndKeyCharExists);
		}

		#endregion

		#region Private methods

		private char GetEncryptedCharIfValid(char originalLetter)
		{
			if (originalLetter.IsLetter())
			{
				encryptedLetter = cipherKey.LetterSequence.ElementAt(originalLetter.ToLower().ToNumber());
				return (char.IsLower(originalLetter)) ? encryptedLetter : char.ToUpper(encryptedLetter);
			}
			else
				return originalLetter;
		}

		private char GetDecryptedCharIfValid(char originalLetter)
		{
			if (originalLetter.IsLetter())
			{
				decryptedLetter = decipherKey.LetterSequence.IndexOf(originalLetter.ToLower()).ToLetter();
				return (char.IsLower(originalLetter)) ? decryptedLetter : char.ToUpper(decryptedLetter);
			}
			else
				return originalLetter;
		}

		private char GetDecryptedCharIfValidAndKeyCharExists(char originalLetter)
		{
			if (originalLetter.IsLetter())
			{
				var number = originalLetter.ToLower().ToNumber();
				var keySequence = cipherKey.LetterSequence;
				var element = keySequence.ElementAt(number);

				if (element == ' ')
				{
					return originalLetter;
				}

				encryptedLetter = element;
				return char.ToUpper(encryptedLetter);
			}
			else
				return originalLetter;
		}

		#endregion
	}
}
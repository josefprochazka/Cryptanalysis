using System.Text;

namespace Cryptanalysis
{
	internal class Vigenere : AbstractCiphers, IEncryption
	{
		#region Fields

		private char actualKeyLetter;
		private int counter;
		private StringBuilder encryptedText;

		#endregion

		#region Public methods

		public StringBuilder GetDecryptedText(StringBuilder cipherText, Key key)
		{
			decipherKey.LetterSequence = key.LetterSequence.ToReversedLetters();
			return GetEncryptedText(cipherText, decipherKey);
		}

		public StringBuilder GetEncryptedText(StringBuilder plainText, Key key)
		{
			plainTextValidChars = plainText.GetOnlyValidChars();
			cipherKey = key;
			counter = 0;
			encryptedText = plainTextValidChars.GetModifiedEachItemText(GetEncryptedCharIfValid);
			return TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(encryptedText, plainText);
		}

		#endregion

		#region Private methods

		private char GetEncryptedCharIfValid(char originalLeter)
		{
			actualKeyLetter = cipherKey.LetterSequence[counter];
			counter = (counter == cipherKey.LetterSequence.Count - 1) ? 0 : counter + 1;
			return originalLeter.ToShiftedCharIfValid(actualKeyLetter.ToNumber());
		}

		#endregion
	}
}
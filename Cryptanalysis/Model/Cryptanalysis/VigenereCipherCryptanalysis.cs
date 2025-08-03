using System;
using System.Linq;

namespace Cryptanalysis
{
	public class VigenereCipherCryptanalysis : AbstractCryptanalysis, ICryptanalysis
	{
		#region Fields

		private string textInColumn;
		private int keyLength;
		private int alphabetLettersCount = CommonSettings.CurrentAplhabetLettersCount;
		private double averageChisquare = 0;

		#endregion

		#region Public methods

		public string BreakByBrutalForceAndChiSquare(string cipherText)
		{
			string cipherTextValidChars = cipherText.GetOnlyValidChars();
			keyLength = GetKeyLengthByIndexOfCoincindence(cipherTextValidChars);
			bestKey = GetKeyByChiSquareOfColumns(cipherTextValidChars, keyLength);
			bestKey.LetterSequence = bestKey.LetterSequence.TransferToString().RemoveRecurringSubstrings().ToList();
			tempDecryptedText = Decryption.GetDecryptedTextByVigenereCipher(cipherTextValidChars, bestKey).ToStringbuilder();
			tempDecryptedText = TextOperations.PutNonValidCharsIntoTextAccordingToOtherText(tempDecryptedText, cipherText.ToStringbuilder());
			CryptanalysisInformation.Enqueue(
					   new CryptanalysisInformation()
					   {
						   Measure = averageChisquare,
						   SequenceKey = bestKey.LetterSequence.TransferToString().ToUpper(),
						   DecryptedText = tempDecryptedText.ToString(0, (tempDecryptedText.Length >= 50) ? 50 : tempDecryptedText.Length - 1)
					   });
			return tempDecryptedText.ToString();
		}

		public string BreakByBrutalForceAndFitness(string cipherText)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region Private methods

		private int GetKeyLengthByIndexOfCoincindence(string cipherText)
		{
			double tempIndexesSum;
			double bestIndex = 0;
			double tempIndex = 0;
			int keyLength = 1;
			CipherTable table;

			for (int tempKeyLength = 2; tempKeyLength < 30; tempKeyLength++)
			{
				table = new CipherTable(tempKeyLength, cipherText.Length / tempKeyLength);
				table.FillTableByRows(cipherText.ToStringbuilder());
				tempIndexesSum = 0;

				for (int column = 0; column < table.ColumnCount; column++)
				{
					textInColumn = "";
					for (int row = 0; row < table.RowCount; row++)
						textInColumn += table.GetCell(column, row);
					tempIndexesSum += statistics.GetIndexOfCoincidence(textInColumn);
				}

				tempIndex = tempIndexesSum / table.ColumnCount;

				if (bestIndex < tempIndex)
				{
					bestIndex = tempIndex;
					keyLength = tempKeyLength;
				}
			}
			return keyLength;
		}

		private Key GetKeyByChiSquareOfColumns(string cipherText, int keyLength)
		{
			bestKey = new Key();
			textInColumn = "";
			string shiftedTextInColumn = "";
			int shiftDecipherKeyForTextInColumn = 0;
			tempChiSquare = 0;
			Caesar caesarCipher = new Caesar();
			Key shiftKey = new Key();
			CipherTable table = new CipherTable(keyLength, cipherText.Length / keyLength);
			table.FillTableByRows(cipherText.ToStringbuilder());

			for (int column = 0; column < table.ColumnCount; column++)
			{
				textInColumn = "";
				bestChiSquare = double.MaxValue;

				for (int row = 0; row < table.RowCount; row++)
					textInColumn += table.GetCell(column, row);

				for (int i = 1; i <= alphabetLettersCount + 1; i++)
				{
					shiftKey.SingleNumber = i;
					shiftedTextInColumn = caesarCipher.GetEncryptedText(textInColumn.ToStringbuilder(), shiftKey).ToString();
					tempChiSquare = statistics.GetChiSquaredValue(shiftedTextInColumn);
					if ((tempChiSquare < bestChiSquare))
					{
						bestChiSquare = tempChiSquare;
						shiftDecipherKeyForTextInColumn = alphabetLettersCount - i;
					}
				}
				bestKey.LetterSequence.Add(shiftDecipherKeyForTextInColumn.ToLetter());
				averageChisquare += bestChiSquare;
			}
			averageChisquare /= table.ColumnCount;
			return bestKey;
		}

		#endregion
	}
}
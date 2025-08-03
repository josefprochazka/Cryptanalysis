using System;
using System.Text;
using System.Windows.Forms;

namespace Cryptanalysis
{
	public class CipherIdentifying
	{
		#region Public methods

		public string GetCipherIdentityMessage(string analysingText)
		{
			int textLength = analysingText.Length;
			FrequencyAnalysis frequencyAnalysis = new FrequencyAnalysis(analysingText);
			double infexOfCoincidence = Math.Round(Analysis.GetIndexOfCoincidence(analysingText), 4);
			double chiSquare = Math.Round(Analysis.GetChiSquaredValue(analysingText), 4);  
			StringBuilder cipherIdentityMessage = new StringBuilder();

			if (analysingText.Length < 1000)
				MessageBox.Show("Tento text má méně, než 1000 znaků. Pro kvalitnější výsledky je potřeba, aby měl text alespoň 1000 znaků.");

			cipherIdentityMessage.Append("Počet všech znaků: " + textLength + Environment.NewLine + "Index koincidence: " + infexOfCoincidence + Environment.NewLine + "Chí-kvadrát: " + chiSquare + Environment.NewLine + Environment.NewLine +
				"Tento text byl pravděpodobně zašifrován šifrou ");

			cipherIdentityMessage.Append(
				frequencyAnalysis.GetLetterFrequency(1).Count < 12 ? "Polybius." :
				frequencyAnalysis.GetLetterFrequency(1).Count == 25 ? "Playfair." :
				(Math.Abs(infexOfCoincidence - 0.063) < 0.01 && chiSquare < textLength) ? "Transpoziční." :
				(Math.Abs(infexOfCoincidence - 0.063) < 0.01 && chiSquare > textLength) ? "Substituční." :
				(Math.Abs(infexOfCoincidence - 0.063) > 0.01) ? "Vigenèrova." : "");

			return cipherIdentityMessage.ToString();
		}

		#endregion
	}
}

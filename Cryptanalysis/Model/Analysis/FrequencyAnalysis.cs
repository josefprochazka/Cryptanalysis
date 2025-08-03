using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Cryptanalysis
{
	class FrequencyAnalysis : AnalysisUtilities
	{
		#region Fields

		private string tempWord;
		private string analysingText;
		private StringBuilder temp = new StringBuilder();
		private Dictionary<string, int> frequencies = new Dictionary<string, int>();
		private string onlyLettersAndSpaces;
		private string[] words;
		private Regex onlyCharsAndSpaces = new Regex("[^a-zA-Z ]");

		#endregion

		#region Public methods

		public FrequencyAnalysis(string analysingText)
		{
			this.analysingText = analysingText;
		}

		public Dictionary<string, int> GetLetterFrequency(int lettersCount)
		{
			frequencies.Clear();
			onlyLettersAndSpaces = onlyCharsAndSpaces.Replace(analysingText, "");
			words = onlyLettersAndSpaces.Split(null);

			for (int i = 0; i < words.Count(); i++)
			{
				if (words[i].Length >= lettersCount)
				{
					tempWord = words[i];

					for (int j = 0; j < tempWord.Length - (lettersCount - 1); j++)
					{
						temp.Clear();
						for (int k = 0; k < lettersCount; k++)
							temp.Append(tempWord[j + k]);

						frequencies[temp.ToString()] = (frequencies.ContainsKey(temp.ToString())) ? frequencies[temp.ToString()] + 1 : 1;
					}
				}
			}

			return frequencies;
		}
		
		#endregion
	}
}

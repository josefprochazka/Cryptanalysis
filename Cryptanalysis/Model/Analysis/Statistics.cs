using Cryptanalysis.Properties;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cryptanalysis
{
	public class Statistics : AnalysisUtilities
	{
		#region Fields

		long fileTrigramsTotalCount = 0;
		private string currentAlphabet = CommonConstants.englishAlphabet;
		private static Dictionary<string, int> currentTextMonogramFrequencies;
		private static Dictionary<string, double> commonMonogramsFrequencies;
		private Dictionary<string, int> commonTrigramFrequencies;
		private double fitness;
		private int trigramFrequency;

		#endregion

		#region Constructors

		public Statistics()
		{
			commonMonogramsFrequencies = GetEnglishMonogramFrequenciesFromFile(false, false);
			commonTrigramFrequencies = GetCommonTrigramFrequenciesFromFile();
		}

		#endregion

		#region Public methods

		public double GetIndexOfCoincidence(string text)
		{
			int totalLettersCount = 0;
			double indexOfCoincidence = 0;

			text = text.ToLower();
			currentTextMonogramFrequencies = new FrequencyAnalysis(text).GetLetterFrequency(1);

			foreach (var frequency in currentTextMonogramFrequencies)
			{
				indexOfCoincidence += frequency.Value * (frequency.Value - 1);
				totalLettersCount += frequency.Value;
			}

			indexOfCoincidence /= totalLettersCount * (totalLettersCount - 1);
			return indexOfCoincidence;
		}

		public double GetChiSquaredValue(string text)
		{
			int currentLetterCount = 0;
			double chiSquaredValue = 0;
			double currentLetterCommonFrequency = 0;

			text = text.ToLower();
			int lettersCount = new Regex("[^a-zA-Z]").Replace(text, "").Length;
			currentTextMonogramFrequencies = new FrequencyAnalysis(text).GetLetterFrequency(1);

			foreach (var letter in currentAlphabet)
			{
				currentTextMonogramFrequencies.TryGetValue(letter.ToString(), out currentLetterCount);
				commonMonogramsFrequencies.TryGetValue(letter.ToString(), out currentLetterCommonFrequency);
				currentLetterCommonFrequency *= lettersCount;
				chiSquaredValue += (Math.Pow((currentLetterCount - currentLetterCommonFrequency), 2)) / currentLetterCommonFrequency;
			}

			return chiSquaredValue;
		}

		public double GetTrigramFitness(string text)
		{
			fitness = 0;
			trigramFrequency = 0;

			text = text.ToLower();
			currentTextMonogramFrequencies = new FrequencyAnalysis(text).GetLetterFrequency(3);

			foreach (var textTrigram in currentTextMonogramFrequencies.Keys)
			{
				if (commonTrigramFrequencies.TryGetValue(textTrigram, out trigramFrequency))
					fitness += Math.Log((double)trigramFrequency / fileTrigramsTotalCount);
			}

			return fitness;
		}

		#endregion

		#region Private methods

		private Dictionary<string, int> GetCommonTrigramFrequenciesFromFile()
		{
			int frequency = 0;
			Dictionary<string, int> commonTrigramFrequencies = new Dictionary<string, int>();

			foreach (string tempTrigramFrequency in Regex.Split(Resources.english_trigrams.ToString(), "\n"))
			{
				int.TryParse(new Regex(@"\d+").Match(tempTrigramFrequency).Value, out frequency);
				fileTrigramsTotalCount += frequency;
				commonTrigramFrequencies.Add(
					new Regex("[A-Z]*").Match(tempTrigramFrequency).Value.ToLower(),
					frequency
					);
			}
			return commonTrigramFrequencies;
		}

		#endregion
	}
}

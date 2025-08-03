using Cryptanalysis.Properties;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Cryptanalysis
{
	public class AnalysisUtilities
	{
		#region Fields

		private double value;

		#endregion

		#region Public methods

		public Dictionary<string, double> GetEnglishMonogramFrequenciesFromFile(bool upperLetters, bool inPercentage)
		{
			Dictionary<string, double> commonMonogramsFrequencies = new Dictionary<string, double>();

			foreach (string frequency in Regex.Split(Resources.english_monograms.ToString(), "\r\n"))
			{
				value = double.Parse(new Regex("[0-9]*,[0-9]*").Match(frequency).Value);
				value = inPercentage ? value * 100 : value;
				commonMonogramsFrequencies.Add(
					upperLetters ? new Regex("[a-z]").Match(frequency).Value.ToUpper() : new Regex("[a-z]").Match(frequency).Value,
					value
					);
			}
			return commonMonogramsFrequencies;
		}
		
		#endregion
	}
}

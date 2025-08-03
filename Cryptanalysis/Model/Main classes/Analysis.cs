using System.Collections.Generic;

namespace Cryptanalysis
{
	class Analysis
	{
		#region Public methods

		public static Dictionary<string, int> GetMonogramsFrequency(string text) => new FrequencyAnalysis(text).GetLetterFrequency(1);

		public static Dictionary<string, int> GetBigramsFrequency(string text) => new FrequencyAnalysis(text).GetLetterFrequency(2);

		public static Dictionary<string, int> GetTrigramsFrequency(string text) => new FrequencyAnalysis(text).GetLetterFrequency(3);

		public static Dictionary<string, int> GetQuadgramsFrequency(string text) => new FrequencyAnalysis(text).GetLetterFrequency(4);

		public static double GetChiSquaredValue(string text) => new Statistics().GetChiSquaredValue(text);

		public static double GetIndexOfCoincidence(string text) => new Statistics().GetIndexOfCoincidence(text);

		public static double GetTrigramFitness(string text) => new Statistics().GetTrigramFitness(text);

		public static string GetCipherIdentityMessage(string text) => new CipherIdentifying().GetCipherIdentityMessage(text);

		#endregion
	}
}

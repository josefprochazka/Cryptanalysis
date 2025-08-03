using System;
using System.Collections.Generic;

namespace Cryptanalysis
{
	internal class DoubleTranspositionCipherCryptanalysis : AbstractCryptanalysis, ICryptanalysis
	{
		#region Constructors

		public DoubleTranspositionCipherCryptanalysis(int maxKeyLength)
		{
			allKeys = GetAllDoubleTranspositionKeys(maxKeyLength);
		}

		#endregion

		#region Public methods

		public string BreakByBrutalForceAndFitness(string cipherText) => BreakByFitness(cipherText, new DoubleTransposition());

		public string BreakByBrutalForceAndChiSquare(string cipherText)
		{
			throw new NotImplementedException();
		}

		#endregion

		#region Private methods

		private List<Key> GetAllDoubleTranspositionKeys(int maxKeyLength)
		{
			List<Key> allKeys = new List<Key>();
			List<Key> allKeyPermutations = GetAllTranspositionKeyPermutations(maxKeyLength);

			foreach (var tempKey1 in allKeyPermutations)
				foreach (var tempKey2 in allKeyPermutations)
					allKeys.Add(new Key() { DoubleTranspositionKey = new DoubleTranspositionKey() { Key1 = tempKey1.LetterSequence, Key2 = tempKey2.LetterSequence } });

			return allKeys;
		}

		#endregion
	}
}
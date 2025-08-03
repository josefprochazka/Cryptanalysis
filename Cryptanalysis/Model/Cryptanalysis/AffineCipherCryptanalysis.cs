using System.Collections.Generic;

namespace Cryptanalysis
{
	class AffineCipherCryptanalysis : AbstractCryptanalysis, ICryptanalysis
	{
		#region Constructors

		public AffineCipherCryptanalysis()
		{
			GenerateAllAffineKeys();
		}

		#endregion

		#region Public methods

		public string BreakByBrutalForceAndFitness(string cipherText) => BreakByFitness(cipherText, new Affine());

		public string BreakByBrutalForceAndChiSquare(string cipherText) => BreakByChiSquareMethod(cipherText, new Affine(), allKeys);

		#endregion

		#region Private methods

		private void GenerateAllAffineKeys()
		{
			allKeys = new List<Key>();
			List<int> possibleAs = new List<int>() { 1, 3, 5, 7, 9, 11, 15, 17, 19, 21, 23, 25 };

			foreach (var A in possibleAs)
				for (int B = 0; B <= 25; B++)
					allKeys.Add(new Key() { AffineKey = new AffineKey() { A = A, B = B } });
		}

		#endregion
	}
}
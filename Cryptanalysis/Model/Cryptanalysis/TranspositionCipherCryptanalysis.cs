using System;

namespace Cryptanalysis
{
	public class TranspositionCipherCryptanalysis : AbstractCryptanalysis, ICryptanalysis
	{
		#region Constructors

		public TranspositionCipherCryptanalysis(int maxKeyLength)
		{
			GetAllTranspositionKeyPermutations(maxKeyLength);
		}

		#endregion

		#region Public methods

		public string BreakByBrutalForceAndFitness(string cipherText)
		{
			return BreakByBrutalForceAndFitness(cipherText, new Transposition(TranspositionType.Columnar, TableType.Irregular));
		}

		public string BreakByBrutalForceAndFitness(string cipherText, IEncryption cipher) => BreakByFitness(cipherText, cipher);

		public string BreakByBrutalForceAndChiSquare(string cipherText)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
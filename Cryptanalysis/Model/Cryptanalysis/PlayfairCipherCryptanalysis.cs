using System;

namespace Cryptanalysis
{
	public class PlayfairCipherCryptanalysis : AbstractCryptanalysis, ICryptanalysis
	{
		#region Fields

		private int iterations;

		#endregion

		#region Constructors

		public PlayfairCipherCryptanalysis(int iterations)
		{
			this.iterations = iterations;
		}

		#endregion

		#region Public methods

		public string BreakByBrutalForceAndFitness(string cipherText)
		{
			return BreakByShotgunHillClimbing(cipherText, iterations, new Playfair());
		}

		public string BreakByBrutalForceAndChiSquare(string cipherText)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}

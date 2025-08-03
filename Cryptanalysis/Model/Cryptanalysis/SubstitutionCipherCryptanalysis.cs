using System;
using System.Collections.Generic;

namespace Cryptanalysis
{
	public class SubstitutionCipherCryptanalysis : AbstractCryptanalysis, ICryptanalysis
	{
		#region Fields
	
		private int iterations;

		#endregion

		#region Constructors

		public SubstitutionCipherCryptanalysis()
		{
		}

		public SubstitutionCipherCryptanalysis(int iterations)
		{
			this.iterations = iterations;
		}

		#endregion

		#region Public methods

		public string BreakByBrutalForceAndFitness(string cipherText)
		{
			return BreakByShotgunHillClimbing(cipherText, iterations, new Substitution());
		}

		public string BreakByBrutalForceAndChiSquare(string cipherText)
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
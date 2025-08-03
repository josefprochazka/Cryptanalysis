using System.Collections.Generic;

namespace Cryptanalysis
{
	public interface ICryptanalysis
	{
		Queue<CryptanalysisInformation> CryptanalysisInformation { get; set; }

		string BreakByBrutalForceAndFitness(string cipherText);

		string BreakByBrutalForceAndChiSquare(string cipherText);
	}
}

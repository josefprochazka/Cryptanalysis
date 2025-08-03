using System.Collections.Generic;
using System.Linq;

namespace Cryptanalysis
{
	public class CaesarCryptanalysis : AbstractCryptanalysis, ICryptanalysis
	{
		#region Constructors

		public CaesarCryptanalysis()
		{
			allKeys = GetAllShiftKeys();
		}

		#endregion

		#region Public methods

		public string BreakByBrutalForceAndFitness(string cipherText) => BreakByFitness(cipherText, new Caesar());

		public string BreakByBrutalForceAndChiSquare(string cipherText) => BreakByChiSquareMethod(cipherText, new Caesar(), allKeys);

		#endregion

		#region Private methods

		private List<Key> GetAllShiftKeys() => Enumerable.Range(1, 25).Select(n => new Key() { SingleNumber = n }).ToList();

		#endregion
	}
}
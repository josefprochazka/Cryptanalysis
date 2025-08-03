namespace Cryptanalysis
{
	class Cryptanalysis
	{
		#region Public methods

		public static string GetCaesarCipherPlainTextByChiSquare(string cipherText) => new CaesarCryptanalysis().BreakByBrutalForceAndChiSquare(cipherText);

		public static string GetCaesarCipherPlainTextByFitnessFunction(string cipherText) => new CaesarCryptanalysis().BreakByBrutalForceAndFitness(cipherText);

		public static string GetAffineCipherPlainTextByFitnessFunction(string cipherText) => new AffineCipherCryptanalysis().BreakByBrutalForceAndFitness(cipherText);

		public static string GetAffineCipherPlainTextByChiSquare(string cipherText) => new AffineCipherCryptanalysis().BreakByBrutalForceAndFitness(cipherText);

		public static string GetVigenereCipherPlainTextyByChiSquare(string cipherText) => new VigenereCipherCryptanalysis().BreakByBrutalForceAndChiSquare(cipherText);

		public static string GetSubstitutionCipherPlainTextByHillClimbing(string cipherText) => new SubstitutionCipherCryptanalysis().BreakByHillClimbing(cipherText);

		public static string GetSubstitutionCipherPlainTextByShotgunHillClimbing(string cipherText, int iterations) => new SubstitutionCipherCryptanalysis().BreakByShotgunHillClimbing(cipherText, iterations, new Substitution());

		public static string GetTranspositionCipherPlainText(string cipherText, int maxKeyLength)
			=> new TranspositionCipherCryptanalysis(maxKeyLength).BreakByBrutalForceAndFitness(cipherText, new Transposition(TranspositionType.Columnar, TableType.Irregular));

		public static string GetTranspositionCipherPlainTextByBrutalForceAttack(string cipherText, int maxKeyLength)
			=> new TranspositionCipherCryptanalysis(maxKeyLength).BreakByBrutalForceAndFitness(cipherText, new Transposition(TranspositionType.Columnar, TableType.Irregular));

		public static string GetDoubleTranspositionCipherPlainTextByBrutalForceAttack(string cipherText, int maxKeyLength)
			=> new DoubleTranspositionCipherCryptanalysis(maxKeyLength).BreakByBrutalForceAndFitness(cipherText);

		#endregion
	}
}

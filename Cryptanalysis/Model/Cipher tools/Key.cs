using System.Collections.Generic;
using System.Linq;

namespace Cryptanalysis
{
	public class Key
	{
		#region Fields

		private int counter;
		private int[] tempArray;

		#endregion

		#region Constructors

		public Key()
		{
			LetterSequence = new List<char>();
			NumberSequence = new List<int>();
			TranspositionNumberSequence = new List<int>();
			AffineKey = new AffineKey();
		}

		#endregion

		#region Properties

		public int SingleNumber { get; set; }

		public List<char> LetterSequence { get; set; }

		public List<int> NumberSequence { get; set; }

		public AffineKey AffineKey { get; set; }

		public List<int> TranspositionNumberSequence { get; set; }

		public DoubleTranspositionKey DoubleTranspositionKey { get; set; }

		#endregion

		#region Public methods

		public void CreateKeyForTranspositionCipher()
		{
			counter = 0;
			tempArray = new int[LetterSequence.Count];

			foreach (var alphabetLetter in CommonSettings.currentAlphabet)
			{
				foreach (var keyLetter in LetterSequence)
				{
					if (alphabetLetter == keyLetter)
						tempArray[LetterSequence.IndexOf(keyLetter)] = counter++;
				}
			}

			TranspositionNumberSequence = tempArray.ToList();
		}

		public void CreateNumberKeyFromLetterKey() => NumberSequence = LetterSequence.ToNumbersOfLetters();


		#endregion
	}

	#region Other classes

	public class AffineKey
	{
		public int A { get; set; }

		public int B { get; set; }

		public int M { get; set; }

		public int InverseOfA { get; set; }

		public void SetKey(int A, int B)
		{
			this.A = A;
			this.B = B;
		}
	}

	public class DoubleTranspositionKey
	{
		public DoubleTranspositionKey()
		{
			Key1 = new List<char>();
			Key2 = new List<char>();
		}

		public List<char> Key1 { get; set; }

		public List<char> Key2 { get; set; }
	}

	#endregion
}
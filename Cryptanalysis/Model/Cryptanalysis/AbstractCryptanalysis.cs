using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cryptanalysis
{
	public abstract class AbstractCryptanalysis
	{
		#region Fields

		protected double bestFitness;
		protected double tempFitness;
		protected double bestChiSquare;
		protected double tempChiSquare;
		protected StringBuilder tempDecryptedText;
		protected Key bestKey;
		protected List<Key> allKeys;
		protected Statistics statistics;
		protected IEnumerable<IEnumerable<char>> keyPermutations;
		protected Substitution substitutionCipher = new Substitution();
		protected IEncryption cipher;
		protected List<Key> neighbors = new List<Key>();
		protected List<char> tempNeighbor;
		protected Random random = new Random();
		protected bool stuck;
		protected Key bestGlobalKey;
		protected double bestGlobalFitness;

		#endregion

		public Queue<CryptanalysisInformation> CryptanalysisInformation { get; set; }

		#region Constructors

		public AbstractCryptanalysis()
		{
			statistics = new Statistics();
			bestKey = new Key();
			tempDecryptedText = new StringBuilder();
			CryptanalysisInformation = new Queue<CryptanalysisInformation>();
			bestKey = new Key();
			bestKey.LetterSequence = new List<char>();
			bestGlobalKey = new Key();
			bestGlobalKey.LetterSequence = new List<char>();
		}

		#endregion

		#region Protected methods

		protected List<Key> GetAllTranspositionKeyPermutations(int maxKeyLength)
		{
			allKeys = new List<Key>();
			List<char> letterSequence = new List<char>();

			for (int i = 2; i <= maxKeyLength; i++)
			{
				letterSequence.Clear();
				letterSequence = CommonSettings.currentAlphabet.Take(i).ToList();
				keyPermutations = ListOperations.GetAllPermutations(letterSequence, letterSequence.Count);
				foreach (var key in keyPermutations)
					allKeys.Add(new Key() { LetterSequence = key.ToList() });
			}
			return allKeys;
		}

		protected string BreakByChiSquareMethod(string cipherText, IEncryption cipher, List<Key> allKeys)
		{
			bestChiSquare = double.MaxValue;
			tempChiSquare = 0;

			foreach (var candidateKey in allKeys)
			{
				tempDecryptedText = cipher.GetDecryptedText(cipherText.ToStringbuilder(), candidateKey);
				tempChiSquare = statistics.GetChiSquaredValue(tempDecryptedText.ToString());
				if (tempChiSquare < bestChiSquare)
				{
					bestChiSquare = tempChiSquare;
					bestKey = candidateKey;
				}
				CryptanalysisInformation.Enqueue(
					   new CryptanalysisInformation()
					   {
						   Measure = tempChiSquare,
						   SingleKey = candidateKey.SingleNumber.ToString(),
						   MultipleKey = candidateKey.AffineKey.A.ToString() + ", " + candidateKey.AffineKey.B.ToString(),
						   DecryptedText = tempDecryptedText.ToString(0, (tempDecryptedText.Length >= 50) ? 50 : tempDecryptedText.Length - 1)
					   });
			}

			return cipher.GetDecryptedText(cipherText.ToStringbuilder(), bestKey).ToString();
		}

		protected string BreakByFitness(string cipherText, IEncryption cipher)
		{
			bestFitness = double.MinValue;
			tempFitness = 0;

			foreach (var candidateKey in allKeys)
			{
				tempDecryptedText = cipher.GetDecryptedText(cipherText.ToStringbuilder(), candidateKey);
				tempFitness = statistics.GetTrigramFitness(tempDecryptedText.ToString());
				if (tempFitness > bestFitness)
				{
					bestFitness = tempFitness;
					bestKey = candidateKey;
				}
				CryptanalysisInformation.Enqueue(
					   new CryptanalysisInformation()
					   {
						   Measure = tempFitness,
						   SingleKey = candidateKey.SingleNumber.ToString(),
						   MultipleKey = candidateKey.AffineKey.A.ToString() + ", " + candidateKey.AffineKey.B.ToString(),
						   SequenceKey = candidateKey.LetterSequence.TransferToString().ToUpper(),
						   DecryptedText = tempDecryptedText.ToString(0, (tempDecryptedText.Length >= 50) ? 50 : tempDecryptedText.Length - 1),
						   TwoSequenciesKey = (candidateKey.DoubleTranspositionKey != null) ? candidateKey.DoubleTranspositionKey.Key1.TransferToString() + ", " + candidateKey.DoubleTranspositionKey.Key2.TransferToString() : ""
					   });
			}

			return cipher.GetDecryptedText(cipherText.ToStringbuilder(), bestKey).ToString();
		}

		public string BreakByHillClimbing(string cipherText)
		{
			bestKey.LetterSequence = RandomsOperations.GetRandomAlphabetPermutation();

			bestFitness = double.MinValue;
			do
			{
				GenerateNeighbors(bestKey.LetterSequence, random);
				stuck = true;
				for (int i = 0; i < neighbors.Count; i++)
				{
					tempDecryptedText = substitutionCipher.GetDecryptedText(cipherText.ToStringbuilder(), neighbors[i]);
					tempFitness = statistics.GetTrigramFitness(tempDecryptedText.ToString());
					if (tempFitness > bestFitness)
					{
						bestFitness = tempFitness;
						bestKey = neighbors[i];
						stuck = false;
						break;
					}
				}
			}
			while (stuck == false);
			return substitutionCipher.GetDecryptedText(cipherText.ToStringbuilder(), bestKey).ToString();
		}

		public string BreakByShotgunHillClimbing(string cipherText, int iterations, IEncryption cipher)
		{
			bestGlobalFitness = double.MinValue;
			bestGlobalKey.LetterSequence = RandomsOperations.GetRandomAlphabetPermutation();
			for (int i = 0; i < iterations; i++)
			{
				bestKey.LetterSequence = RandomsOperations.GetRandomAlphabetPermutation();
				bestFitness = double.MinValue;
				do
				{
					GenerateNeighbors(bestKey.LetterSequence, random);
					stuck = true;
					for (int j = 0; j < neighbors.Count; j++)
					{
						tempDecryptedText = cipher.GetDecryptedText(cipherText.ToStringbuilder(), neighbors[j]);
						tempFitness = statistics.GetTrigramFitness(tempDecryptedText.ToString());
						if (tempFitness > bestFitness)
						{
							bestFitness = tempFitness;
							bestKey = neighbors[j];
							if (bestFitness > bestGlobalFitness)
							{
								bestGlobalFitness = bestFitness;
								bestGlobalKey = neighbors[j];
							}
							stuck = false;
							CryptanalysisInformation.Enqueue(
								  new CryptanalysisInformation()
								  {
									  Measure = bestFitness,
									  SequenceKey = bestKey.LetterSequence.TransferToString(),
									  DecryptedText = tempDecryptedText.ToString(0, (tempDecryptedText.Length >= 50) ? 50 : tempDecryptedText.Length - 1)
								  });
							break;
						}
					}
				}
				while (stuck == false);
			}

			return cipher.GetDecryptedText(cipherText.ToStringbuilder(), bestGlobalKey).ToString();
		}


		protected void GenerateNeighbors(List<char> bestSequence, Random random)
		{
			neighbors.Clear();
			tempNeighbor = new List<char>();
			neighbors.Add(new Key() { LetterSequence = bestSequence });

			for (int i = 0; i < bestSequence.Count - 1; i++)
			{
				tempNeighbor = bestSequence;
				neighbors.Add(new Key() { LetterSequence = tempNeighbor.Swap(i, i + 1) });
			}
		}


		#endregion
	}

	#region Other classes

	public class CryptanalysisInformation : IComparable<CryptanalysisInformation>
	{
		public int Sequence { get; set; }

		public string DecryptedText { get; set; }

		public string SingleKey { get; set; }

		public string MultipleKey { get; set; }

		public string SequenceKey { get; set; }

		public string TwoSequenciesKey { get; set; }

		private double measure = 0;
		public double Measure
		{
			get
			{
				return Math.Round(measure, 2);
			}
			set
			{
				measure = value;
			}
		}

		public int CompareTo(CryptanalysisInformation other)
		{
			return other.Measure.CompareTo(Measure);
		}
	}

	#endregion
}
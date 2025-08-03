using System;
using System.Collections.Generic;
using System.Linq;

namespace Cryptanalysis
{
	public static class ListOperations
	{
		#region Public methods

		public static List<T> GetModifiedEachItemList<T>(List<T> list, Func<T, T> modifyingMethod)
		{
			List<T> newList = new List<T>();

			foreach (T item in list)
				newList.Add(modifyingMethod(item));

			return newList;
		}

		public static List<T2> GetModifiedEachItemList<T1, T2>(List<T1> list, Func<T1, T2> modifyingMethod)
		{
			List<T2> newList = new List<T2>();

			foreach (T1 item in list)
				newList.Add(modifyingMethod(item));

			return newList;
		}

		public static IEnumerable<IEnumerable<T>> GetAllPermutations<T>(IEnumerable<T> list, int length)
		{
			if (length == 1)
				return list.Select(t => new T[] { t });
			return GetAllPermutations(list, length - 1)
				.SelectMany(t => list.Where(o => !t.Contains(o)),
				(t1, t2) => t1.Concat(new T[] { t2 }));
		}

		public static List<T> TakeRange<T>(this List<T> list, int count)
		{
			if (list.Count < 1)
				return new List<T>();
			if (count > list.Count)
				count = list.Count;
			List<T> temp = new List<T>();
			for (int i = 0; i < count; i++)
				temp.Add(list.ElementAt(i));
			return temp;
		}

		public static List<char> Swap(this List<char> list, int indexA, int indexB)
		{
			char tempChar = list[indexA];
			list[indexA] = list[indexB];
			list[indexB] = tempChar;
			return list;
		}

		#endregion
	}
}
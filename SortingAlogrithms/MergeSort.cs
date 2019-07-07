using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlogrithms
{
	/// <summary>
	/// A Merge Sort is an example of divide and conquer paradigm. It is a comparison based sorting algorithm. It takes a list and divides the list in two lists of almost equal lengths. It then sorts the list by applying merge sort recursively, which divides the divided lists into two sublists for each and applying the merge sort to them as well.
	/// A merge sort works as follows:
	/// 1. If the list is of length 0 or 1, then it is already sorted.Otherwise:
	/// 2. Divide the unsorted list into two sublists of about half the size.
	/// 3. Sort each sublist recursively by re-applying merge sort.
	/// 4. Merge the two sublists back into one sorted list.
	/// Ref: https://www.codeproject.com/Articles/79040/Sorting-Algorithms-Codes-in-C-NET
	/// </summary>
	class MergeSort
	{
		public static List<int>Sort(List<int> m)
		{
			List<int> result = new List<int>();
			List<int> left = new List<int>();
			List<int> right = new List<int>();
			if (m.Count <= 1)
				return m;

			int middle = m.Count / 2;
			for (int i = 0; i < middle; i++)
				left.Add(m[i]);
			for (int i = middle; i < m.Count; i++)
				right.Add(m[i]);
			left = Sort(left);
			right = Sort(right);
			if (left[left.Count - 1] <= right[0])
				return Append(left, right);
			result = Merge(left, right);
			return result;
		}

		private static List<int> Append(List<int> a, List<int> b)
		{
			List<int> result = new List<int>(a);
			foreach (int x in b)
				result.Add(x);
			return result;
		}

		private static List<int> Merge(List<int> a, List<int> b)
		{
			List<int> s = new List<int>();
			while (a.Count > 0 && b.Count > 0)
			{
				if (a[0] < b[0])
				{
					s.Add(a[0]);
					a.RemoveAt(0);
				}
				else
				{
					s.Add(b[0]);
					b.RemoveAt(0);
				}
			}
			while (a.Count > 0)
			{
				s.Add(a[0]);
				a.RemoveAt(0);
			}
			while (b.Count > 0)
			{
				s.Add(b[0]);
				b.RemoveAt(0);
			}

			return s;
		}

	}
}



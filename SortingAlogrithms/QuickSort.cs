using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlogrithms
{
	/// <summary>
	/// The QuickSort works as divide and conquer. It divides the unsorted list into sublists and then sorts the individual lists.
	///	The steps of the QuickSort are:
	///	      1. Pick an element, called a Pivot, from the list.
	///	      2. Reorder the list so that all elements with values less than the pivot come before the pivot, 
	///	           while all elements with values greater than the pivot come after it(equal values can go either way). 
	///	           After this partitioning, the pivot is in its final position.This is called the partition operation.
	///	      3. Recursively sort the sub-list of lesser elements and the sub-list of greater elements.
	///	      Ref: https://www.codeproject.com/Articles/79040/Sorting-Algorithms-Codes-in-C-NET
	/// </summary>
	class QuickSort
	{
		public static List<int> Sort(List<int> a)
		{
			Random r = new Random();
			List<int> less = new List<int>();
			List<int> greater = new List<int>();
			if (a.Count <= 1)
				return a;
			int pos = r.Next(a.Count);

			int pivot = a[pos];
			a.RemoveAt(pos);
			foreach (int x in a)
			{
				if (x <= pivot)
				{
					less.Add(x);
				}
				else
				{
					greater.Add(x);
				}
			}
			return Concat(Sort(less), pivot, Sort(greater));
		}

		public static List<int> Concat(List<int> less, int pivot, List<int> greater)
		{
			List<int> sorted = new List<int>(less);
			sorted.Add(pivot);
			foreach (int i in greater)
			{

				sorted.Add(i);
			}

			return sorted;
		}
	}
}

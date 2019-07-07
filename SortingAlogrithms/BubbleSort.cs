using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlogrithms
{
	/// <summary>
	/// In bubble sort, each element of the unsorted list is compared to the next element and if the value of first element is greater than 
	/// the value of the second element, then they are swapped.
	/// Ref: https://www.codeproject.com/Articles/79040/Sorting-Algorithms-Codes-in-C-NET
	/// </summary>
	class BubbleSort
	{
		public static List<int> Sort(List<int> a)
		{
			int temp;
			// foreach(int i in a)
			for (int i = 1; i <= a.Count; i++)
				for (int j = 0; j < a.Count - i; j++)
					if (a[j] > a[j + 1])
					{
						temp = a[j];
						a[j] = a[j + 1];
						a[j + 1] = temp;
					}
			return a;
		}
	}
}

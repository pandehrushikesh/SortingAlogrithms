using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlogrithms
{
	/// <summary>
	/// The heapSort belongs to the selection sort algorithm paradigm and it is a comparison based algorithm.
	///The Heapsort works as a recursive fashion.It makes the heap of the given data and then sorts that heaps
	///Ref: https://www.codeproject.com/Articles/79040/Sorting-Algorithms-Codes-in-C-NET
	/// </summary>
	class HeapSort
	{
		public static int[] Sort(int[] arr, int n)
		{
			for (int i = n / 2 - 1; i >= 0; i--)
				Heapify(arr, n, i);
			for (int i = n - 1; i >= 0; i--)
			{
				int temp = arr[0];
				arr[0] = arr[i];
				arr[i] = temp;
				Heapify(arr, i, 0);
			}

			return arr;
		}
		static void Heapify(int[] arr, int n, int i)
		{
			int largest = i;
			int left = 2 * i + 1;
			int right = 2 * i + 2;
			if (left < n && arr[left] > arr[largest])
				largest = left;
			if (right < n && arr[right] > arr[largest])
				largest = right;
			if (largest != i)
			{
				int swap = arr[i];
				arr[i] = arr[largest];
				arr[largest] = swap;
				Heapify(arr, n, largest);
			}
		}
	}
}

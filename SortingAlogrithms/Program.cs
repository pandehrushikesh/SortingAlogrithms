using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlogrithms
{
	class Program
	{
		static void Main(string[] args)
		{
			
			DisplayList(GetList(), "Unsorted List");

			DisplayList(QuickSort.Sort(GetList()), "\t Quick Sort");
			DisplayList(MergeSort.Sort(GetList()), "\t Merge Sort");
			int[] hipSortArray = GetList().ToArray();
			DisplayList(HeapSort.Sort(hipSortArray, hipSortArray.Length).ToList(), "\t Heap Sort");
			DisplayList(BubbleSort.Sort(GetList()), "\t Bubble Sort");

			Console.Read();
		}

		private static List<int> GetList()
		{
			return new List<int>() { 3,5,2,6,9,7,4,9,2,1 };
		}

		private static  void DisplayList(List<int> list, string caption)
		{
			StringBuilder builder = new StringBuilder();
			Console.WriteLine();
			foreach (int i in list)
			{
					builder.Append($" {i},");
			}
			
			Console.Write($"{caption}: {builder.ToString().TrimEnd(",".ToCharArray())}");
			Console.WriteLine();
		}
	}
}

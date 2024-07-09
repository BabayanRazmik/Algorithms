using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class SelectionSort
    {
        public int findSmallest(int[] arr)
        {
            int smallest = arr[0];
            int smallestIndex = 0;
            for (int i = 1; i < arr.Length; ++i) 
            {
                if (arr[i] < smallest)
                {
                    smallest = arr[i];
                    smallestIndex = i;
                }
            }
            return smallestIndex;
        }

        public int[] selection_sort(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int smallestIndex = 0;
            for (int i = 0; i < newArr.Length; ++i)
            {
                smallestIndex = findSmallest(arr);
                newArr[i] = arr[smallestIndex];
                arr = arr.Where(val => val != arr[smallestIndex]).ToArray();
            }
            return newArr;
        }
    }
}

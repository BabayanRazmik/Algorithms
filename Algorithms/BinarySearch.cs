using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class BinarySearch
    {
        public int? binary_search(int[] arr, int number)
        {
            int start = 0;
            int end = arr.Length;
            int mid = 0;
            int midNumber = 0;

            while (start <= end)
            {
                mid = (start + end) / 2;
                midNumber = arr[mid];

                if (midNumber == number)
                {
                    return mid;
                }
                else if (midNumber > number)
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return null;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    public class MathOperations
    {
        static int add(int a, int b)
        {
            return a + b;
        }

        private static int binarySearch(int[] arr, int value, int left, int right)
        {
            while (left <= right)
            {
                int middle = (left + right + 1 ) / 2 + 1;
                if (arr[middle] == value)
                    return middle;
                else if (arr[middle] > value)
                    right = middle - 1;
                else
                    left = middle + 1;
            }
            return -1;
        }

        public static int find(IEnumerable<int> array, int val)
        {
            return binarySearch(array.ToArray(), val, 0, array.Count() - 1);
        }
    }
}

using System;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max) 
            {
                int mid = (min + max) / 2; 
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;  
                }
                else
                {
                    min = mid + 1;  
                }
            }
            return -1;
        }
    }
}

// 0-я итерация: n
// 1-я итерация: n / 2
// 2-я итерация: n / 4
// 3-я итерация: n / 8
// 4-я итерация: n / 16
// …
// i - я итерация: n / 2i

// i = log(n)

// O(log(n))

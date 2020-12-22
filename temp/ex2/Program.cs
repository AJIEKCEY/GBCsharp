using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string sequence = GetNumbersSequence();
            int[] nums = ParseToNumbersArray(sequence);
            Console.WriteLine(GetSum(nums));
        }

        static string GetNumbersSequence()
        {
            Console.WriteLine("Введите последовательность натуральных чисел разделенных пробелом или запятой");
            return Console.ReadLine();
        }

        static int[] ParseToNumbersArray(string sequence)
        {
            char[] delimiterChars = { ' ', ',' };
            string[] strArr = sequence.Split(delimiterChars);
            int[] intArr = new int[strArr.Length];
            for (int i = 0; i < strArr.Length; i++)
            {
                intArr[i] = Convert.ToInt32(strArr[i]);
            }
            return intArr;
        } 

        static int GetSum(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum  += nums[i];
            }
            return sum;
        }
    }
}

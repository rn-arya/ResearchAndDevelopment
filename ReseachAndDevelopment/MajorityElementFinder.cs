using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReseachAndDevelopment
{
    public class MajorityElementFinder
    {
        public static int FindMajorityElementwithFor(int[] arr)
        {
            int candidate = 0;
            int count = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (count == 0)
                {
                    count = 1;
                    candidate = arr[i];
                }
                else if (arr[i] == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == candidate)
                {
                    count++;
                }
            }
            return count > arr.Length / 2 ? candidate : -1;
        }

        public static int FindMajorityElement(int[] arr)
        {
            int candidate = 0;
            int count = 0;

            // First pass: find a candidate
            foreach (var num in arr)
            {
                if (count == 0)
                {
                    candidate = num;
                    count = 1;
                }
                else if (num == candidate)
                {
                    count++;
                }
                else
                {
                    count--;
                }
            }

            // Second pass: verify the candidate
            count = 0;
            foreach (var num in arr)
            {
                if (num == candidate)
                {
                    count++;
                }
            }

            return count > arr.Length / 2 ? candidate : -1;
        }
    }

}

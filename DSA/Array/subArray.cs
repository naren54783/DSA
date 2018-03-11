using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSA.Array
{
  public static  class subArray
    {
        //Largest Sum Contiguous Subarray
        public static int LargestSumContiguousSubArray(int[] arr)
        {
            int max_so_far = 0;
            int max_end_here = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                max_end_here += arr[i];

                if (max_end_here < 0)
                    max_end_here = 0;
                //if (max_so_far < max_end_here)
                //{
                //    max_so_far = max_end_here;
                //}

                max_so_far = Math.Max(max_so_far, max_end_here);
            }

            return max_so_far;
        }

    }
}

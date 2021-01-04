using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes
{
    class LeetCode
    {
        public int SingleNumber(int[] nums)
        {
            // Variable to hold answer
            int ans = 0;

            // Begin by sorting array in ascending order
            Array.Sort(nums);


            for (int i = 0; i < nums.Length; i++)
            {
                // Check if we are on the last element
                if (i + 1 == nums.Length - 1)
                    return nums[i + 1];
                else
                {
                    // If i == 0 then the ans is nums[i] else answer is nums[i+1]
                    if (nums[i] != nums[i + 1])
                    {
                        if (i == 0)
                            return nums[i];
                        else
                        {
                            if (nums[i + 1] != nums[i + 2])
                                return nums[i + 1];
                        }
                    }
                }
            }
            // Return answer
            return 0;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Challenges
{
    class GetMoneySpent
    {
        static int getMoneySpent(int[] keyboards, int[] drives, int b)
        {
            /*
             * Write your code here.
             */
            int mostExpensive = 0, sum = 0;
            

            for (int i = 0; i < keyboards.Length; i++)
               for (int j = 0; j < drives.Length; j++)
                {
                    sum = keyboards[i] + drives[j];

                    if (sum <= b && sum > mostExpensive)
                        mostExpensive = sum;
                }
            if (mostExpensive == 0)
                return -1;
            else
                return mostExpensive;

        }
    }
}

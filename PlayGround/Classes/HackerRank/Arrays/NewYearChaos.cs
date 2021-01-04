using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Arrays
{
    class NewYearChaos
    {
        public static void minimumBribes(int[] q)
        {
            int count = 0;

            for (int i = 1; i <= q.Length; i++)
            {
                if (q[i-1] - i > 2)
                {
                    Console.WriteLine("Too chaotic");
                    return;
                }
                else if (q[i] - i <= 2)
                    count++;
            }
            Console.WriteLine(count);
        }
    }
}

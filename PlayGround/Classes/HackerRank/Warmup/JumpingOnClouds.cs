using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Warmup
{
    class JumpingOnClouds
    {
        // Complete the jumpingOnClouds function below.
        public static int jumpingOnClouds(int[] c)
        {
            int jumpCount = 0;

            for (int i = 0; i < c.Length - 1; i++)
                if (((i+2) < c.Length) && (c[i + 2] == 0))
                {
                    jumpCount += 1;
                    i += 1;
                }
                else
                    jumpCount += 1;
            return jumpCount;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Warmup
{
    class CountingValleys
    {
        /*
       * Complete the 'countingValleys' function below.
       *
       * The function is expected to return an INTEGER.
       * The function accepts following parameters:
       *  1. INTEGER steps
       *  2. STRING path
       */

        public static int countingValleys(int steps, string path)
        {
            char[] pathArray = path.ToCharArray();
            int valleys = 0, sum =0;

            for (int i = 0; i < steps; i++)
            {
                if (pathArray[i] == 'D')
                    sum -= 1;
                else
                    sum += 1;

                if ((sum == 0) && ((pathArray[i]) == 'U'))
                    valleys += 1;
            }

            return valleys;
        }
    }
}

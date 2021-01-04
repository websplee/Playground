using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace PlayGround.Classes.HackerRank.Warmup
{
    class RepeatedString
    {
        // Complete the repeatedString function below.
        public static long repeatedString(string s, long n)
        {
            // number of a's
            long noAs = s.Count(c => c == 'a');

            // number of times noAs must be multiplied
            noAs *= (n / s.Length);
            
            // in case it is not a multiple get the substring 
            if ((n % s.Length) != 0)
            {
                // get temp string 
                string tmpString = s.Substring(0, (int)(n % s.Length));
                noAs += tmpString.Count(c => c == 'a');
            }

            return noAs;
        }
    }
}

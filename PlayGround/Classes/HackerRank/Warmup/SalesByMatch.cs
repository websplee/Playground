using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Warmup
{
    class SalesByMatch
    {
        static int sockMerchant(int n, int[] ar)
        {
            // Dictionary to hold the values
            IDictionary<int, int> sockColorCount = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (sockColorCount.ContainsKey(ar[i]))
                    sockColorCount[ar[i]] += 1;
                else
                    sockColorCount.Add(ar[i], 1);
            }

            return sockPairCount(sockColorCount);
        }

        static int sockPairCount(IDictionary<int, int> keyValuePairs)
        {
            int pairs = 0;

            foreach (var kp in keyValuePairs)
                pairs += kp.Value / 2;

            return pairs;
        }
    }
}

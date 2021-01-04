using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Challenges
{
    class PageCount
    {
        public static int pageCount(int n, int p)
        {
            /*
             * Write your code here.
             */
            int mid = n / 2, pages = 0;

            if (p <= mid)
                pages = p / 2;
            else
            {
                if (n % 2 == 0 && (n - p) == 1)
                    return 1;
                pages += (n - p) / 2;
            }

            return pages;
        }
    }
}

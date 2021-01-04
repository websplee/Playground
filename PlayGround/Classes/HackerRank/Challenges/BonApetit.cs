using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Challenges
{
    class BonApetit
    {
        public static void bonAppetit(List<int> bill, int k, int b)
        {
            int annaBill = 0, diffBill = 0, totalBill = 0;

            foreach (var item in bill)
                totalBill += item;
            annaBill = (totalBill  - bill[k]) / 2;

            diffBill = b - annaBill;

            if (diffBill == 0)
                Console.WriteLine("Bon Appetit");
            else
                Console.WriteLine(diffBill);
        }
    }
}

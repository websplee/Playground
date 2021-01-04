using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Arrays
{
    class LeftRotation
    {
        static int[] rotLeft(int[] a, int d)
        {
            int[] arr = new int[a.Length];
            int ind = 0;

            for (int i = 0; i < a.Length; i++)
            {
                ind = i - d;

                if (ind < 0)
                    ind += a.Length;

                arr[ind] = a[i];
            }

            return arr;
        }
    }
}

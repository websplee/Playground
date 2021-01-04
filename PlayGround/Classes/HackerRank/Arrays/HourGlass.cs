using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes.HackerRank.Arrays
{
    class HourGlass
    {
        // Complete the hourglassSum function below.
        public static int hourglassSum(int[][] arr)
        {
            int hgSum = 0, maxSum = -999999;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (maxSum < hgSum)
                        maxSum = hgSum;
                    hgSum = 0;

                    for (int x = 0; x < 3; x++)
                    {
                        for (int y = 0; y < 3; y++)
                        {
                            if (!(x == 1 && (y == 0 || y == 2)))
                                hgSum += arr[i + x][j + y];                           
                        }
                    }                    
                }
                    
            }                            
            return maxSum;

        }
    }
}

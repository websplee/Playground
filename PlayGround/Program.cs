using System;
using System.IO;
using PlayGround.Classes;
using PlayGround.Classes.HackerRank.Arrays;
using PlayGround.Classes.HackerRank.Warmup;
using PlayGround.Classes.HackerRank.Challenges;

namespace PlayGround
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int[][] arr = new int[6][];
            arr[0] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[1] = new int[6] { 0, 1, 0, 0, 0, 0 };
            arr[2] = new int[6] { 1, 1, 1, 0, 0, 0 };
            arr[3] = new int[6] { 0, 0, 2, 4, 4, 0 };
            arr[4] = new int[6] { 0, 0, 0, 2, 0, 0 };
            arr[5] = new int[6] { 0, 0, 1, 2, 4, 0 };

            var sum = HourGlass.hourglassSum(arr);*/
           

            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            NewYearChaos.minimumBribes(arr);

            //int result = EqualityInArray.equalizeArray(arr);

            //Console.WriteLine(result);


            // int[] ar = { 0, 0, 1, 0, 0, 1, 0 };
            // var jumps = JumpingOnClouds.jumpingOnClouds(ar);
            // var count = CountingValleys.countingValleys(8, "UDDDUDUU");
            /*
             * This problem was recently asked by Google.

             * Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

             * For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

             * Bonus: Can you do this in one pass?
             *
            DailyProblems dP = new DailyProblems();
            dP.ElementsSum(); 
            int[] vals = { 1, 2, 3, 4, 5, 6, 7,8,9,10,11,12 };

            int[] vals4 = vals[^8..];
            Console.WriteLine("[{0}]", string.Join(", ", vals4));*/
            Console.ReadKey();

        }
    }
}

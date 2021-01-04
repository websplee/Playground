using System.Collections.Generic;
using System.Linq;


namespace PlayGround.Classes.HackerRank.Challenges
{
    class EqualityInArray
    {
        public static int equalizeArray(int[] arr)
        {
            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                if (dic.ContainsKey(arr[i]))
                    dic[arr[i]]++;
                else
                    dic.Add(arr[i], 1);
            }

            var highestOccurence = dic.OrderByDescending(x => x.Value).Take(1);

            return (arr.Length - highestOccurence.First().Value);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace PlayGround.Classes
{
    class CArray
    {
        private int[] arr;
        private int upper;
        private int numElements;
        public CArray(int size)
        {
            arr = new int[size];
            upper = size - 1;
            numElements = 0;
        }

        public void Insert(int item)
        {
            arr[numElements] = item;
            numElements++;
        }
        public void DisplayElements()
        {
            for (int i = 0; i <= upper; i++)
                Console.Write(arr[i] + " ");
        }
        public void Clear()
        {
            for (int i = 0; i <= upper; i++)
                arr[i] = 0;
            numElements = 0;
        }
        
        public void BubbleSort()
        {
            int temp = 0;
            for (int outer = upper; outer > 1; outer--)
                for (int inner = 0; inner < upper; inner++)               
                    if(arr[inner] < arr[inner+1])
                    {
                        temp = arr[inner];
                        arr[inner] = arr[inner + 1];
                        arr[inner + 1] = temp;
                    }                
        }

        public void SelectionSort()
        {
            int min, temp;

            for (int outer = 0; outer <= upper; outer++)
            {
                min = outer;
                for (int inner = outer + 1; inner <= upper; inner++)                
                    if (arr[inner] < arr[min])
                        min = inner;
                temp = arr[outer];
                arr[outer] = arr[min];
                arr[min] = temp;  
            }
        }

        public void InsertionSort()
        {
            int inner, temp;
            for (int outer = 1; outer <= upper; outer++)
            {
                temp = arr[outer];
                inner = outer;
                while (inner > 0 && arr[inner - 1] >= temp)
                {
                    arr[inner] = arr[inner - 1];
                    inner -= 1;
                }
                arr[inner] = temp;
            }
        }

        public void CountDuplicates()
        {
            var dict = new Dictionary<int, int>();
            foreach (var value in arr)
            {
                if (dict.ContainsKey(value)) dict[value]++;
                else dict[value] = 1;
            }
            foreach (var pair in dict)
                Console.WriteLine("Value {0} occurred {1} times", pair.Key, pair.Value);
            Console.ReadKey();
        }

        /*public static List<string> fung(List<string> text)
        {
            List<string> tempArr, arr = new List<string>();

            tempArr = text;
            arr = text;

            foreach(var element in text)
            {
                tempArr.RemoveAt(0);
                foreach(var innerElement in tempArr)
                {
                    arr.RemoveAt
                }
            }
        }
        public bool test(string a, string b)
        {
            List<string> arr = new List<string>();
            char[] aArr = a.ToCharArray();
            if( a.Length == b.Length)

            foreach(var element in arr)
            {
                arr.RemoveAll(i => i == "test");
                    arr[]
            }
        }*/
    }
}

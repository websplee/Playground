using System;

namespace PlayGround
{
    class DailyProblems
    {
        int[] numArray;
        int arraySize = 0;
        int sumValue = 0;

        public void ElementsSum()
        {
            Console.Write("Enter sum value: ");
            sumValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the size of the array :");
            arraySize = Convert.ToInt32(Console.ReadLine());
            // Initialize array
            numArray = new int[arraySize];

            // Get input for the array elements
            for (int i = 0; i < arraySize; i++)
            {
                Console.Write("Element " + (i + 1) + ": ");
                numArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Moment of truth...: " + EvaluateElementSum());
            ArrayProduct();
            Console.ReadLine();
        }

        private bool EvaluateElementSum()
        {
            bool flag = false;
            int difValue = 0;

            for (int i = 0; i < arraySize; i++)
            {
                if (sumValue > numArray[i])
                {
                    difValue = sumValue - numArray[i];
                    for (int k = i+1; k < arraySize; k++)
                    {
                        if (difValue == numArray[k])
                            return true;
                    }
                }
            }

            return flag;
        }

        private void ArrayProduct()
        {
            int[] prodArray = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                prodArray[i] = 1;

                for (int k = 0; k < arraySize; k++)
                {
                    if(k!=i)
                    {
                        prodArray[i] *= numArray[k];
                    }
                }

                Console.WriteLine(prodArray[i] + " , ");
            }
        }
    }
}

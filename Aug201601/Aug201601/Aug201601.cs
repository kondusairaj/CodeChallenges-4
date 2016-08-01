using System;

namespace Aug201601
{
    public class Aug201601
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input != null)
            {
                string[] inputArr = input.Split(' ', ',');
                int length = inputArr.Length;
                int[] arr = new int[length];
                for (int i = 0; i < length; i++)
                {
                    arr[i] = Convert.ToInt32(inputArr[i]);
                }
                Console.WriteLine("TEST CASE : " + GetStatus1(arr, length));
                //Console.WriteLine("TEST CASE : " + GetStatus2(arr, length));  //remove comment to run
            }

            Console.ReadKey();
        }

        //Complexity : O(n)
        public static string GetStatus1(int[] arr, int length)
        {
            int leftSum = arr[0];
            int rightSum = arr[length - 1];
            int i = 0, j = length - 1;
            while (j - i != 2)
            {
                if (leftSum < rightSum)
                {
                    leftSum += arr[++i];
                }
                else if (leftSum > rightSum)
                {
                    rightSum += arr[--j];
                }
                else
                {
                    leftSum += arr[++i];
                    rightSum += arr[--j];
                }
            }
            if (leftSum == rightSum)
            {
                return "PASSED";
            }
            return "FAILED";
        }

        //Complexity : O(2n) // Calculating rightSum at initial is extra overhead here
        public static string GetStatus2(int[] arr, int length)
        {
            int leftSum = arr[0];
            int rightSum = arr[2];
            for (int i = 3; i < length; i++)
            {
                rightSum = rightSum + arr[i];
            }
            if (leftSum == rightSum)
            {
                return "PASSED";
            }
            int p = 1;
            while (p < length - 2)
            {
                leftSum = leftSum + arr[p];
                rightSum = rightSum - arr[p + 1];
                if (leftSum == rightSum)
                {
                    return "PASSED";
                }
                p++;
            }
            return "FAILED";
        }
    }
}

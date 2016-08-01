using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                Console.WriteLine("TEST CASE : " + GetStatus(arr, length));
            }

            Console.ReadKey();
        }

        public static string GetStatus(int[] arr, int length)
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

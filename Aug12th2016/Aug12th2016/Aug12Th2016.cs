using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aug12th2016
{
    public class Aug12Th2016
    {
        public static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (input != null)
            {
                string encryptedString = Encrypt(input);
                Console.WriteLine("\nEncrypted String : " + encryptedString);

                string decryptedString = Decrypt(encryptedString);

                Console.WriteLine("\n\nDecrypted String : " + decryptedString);
            }
            Console.ReadKey();
        }

        /// <summary>
        /// Encryption of the string
        /// Time Complexity : O(n), where n is the length of string
        /// Space Complexity : O(n), where n is the length of string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Encrypt(string input)
        {
            int length = input.Length;
            string[] wordsArr = input.Split(' ');
            int noofWords = wordsArr.Length;
            int[] spaceIndexes = new int[noofWords - 1];
            StringBuilder inputBuilder = new StringBuilder(length);
            StringBuilder outputBuilder = new StringBuilder();
            for (int i = 0; i < noofWords - 1; i++)
            {
                inputBuilder.Append(wordsArr[i]);
                spaceIndexes[i] = inputBuilder.Length + 1;
            }
            inputBuilder.Append(wordsArr[noofWords - 1]);

            int inLenwSpace = inputBuilder.Length;
            int rows = (int)Math.Sqrt(1.0 * inLenwSpace);
            int columns = (int)Math.Ceiling(Math.Sqrt(1.0 * inLenwSpace));
            if (rows * columns < inLenwSpace)
            {
                rows += 1;
            }
            for (int i = 0; i < columns; i++)
            {
                int j = i, k = 0;
                while (k < rows && j < inLenwSpace)
                {
                    outputBuilder.Append(inputBuilder[j]);
                    j += columns;
                    k++;
                }
                outputBuilder.Append(" ");
            }
            outputBuilder.Append("numsp");
            foreach (int index in spaceIndexes)
            {
                outputBuilder.Append(" " + index);
            }
            return outputBuilder.ToString();
        }

        /// <summary>
        /// Decryption of the string
        /// Time Complexity : O(n), where n is the length of string
        /// Space Complexity : O(n), where n is the length of string
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static string Decrypt(string input)
        {
            int indexofnumps = input.IndexOf("numsp", StringComparison.Ordinal);
            if (indexofnumps != -1)
            {
                string inTobeDecrypted = input.Substring(0, indexofnumps - 1);
                string spacesStr = input.Substring(indexofnumps + 5);
                int spaceStrLen = spacesStr.Length;
                string[] spaceIndex = new string[spaceStrLen];
                if (spaceStrLen > 0)
                {
                    spaceIndex = spacesStr.Trim().Split(' ');
                }
                string[] wordsArr = inTobeDecrypted.Split(' ');
                int noofWords = wordsArr.Length;
                int lenofFirstStr = wordsArr[0].Length;
                StringBuilder outputBuilder = new StringBuilder(inTobeDecrypted.Length - (noofWords - 1) + spaceStrLen);
                int j = 0;
                while (j < lenofFirstStr)
                {
                    for (int i = 0; i < noofWords; i++)
                    {
                        if (j < wordsArr[i].Length)
                        {
                            outputBuilder.Append(wordsArr[i][j]);
                        }
                    }
                    j++;
                }

                int z = 0;
                foreach (string index in spaceIndex)
                {
                    int spacePosition = Convert.ToInt32(index) - 1 + z;
                    outputBuilder.Insert(spacePosition, " ");
                    z++;
                }
                return outputBuilder.ToString();
            }
            return null;
        }
    }
}

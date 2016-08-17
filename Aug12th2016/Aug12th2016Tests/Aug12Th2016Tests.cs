using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Aug12th2016;

namespace Aug12th2016Tests
{
    [TestClass]
    public class Aug12Th2016Tests
    {
        [TestMethod]
        public void TestMethod1()
        {
            string input = "if man was meant to stay on the ground god would have given us roots";
            string encryptedString = Aug12Th2016.Encrypt(input);
            Console.WriteLine("\nEncrypted String : " + encryptedString);

            string decryptedString = Aug12Th2016.Decrypt(encryptedString);

            Console.WriteLine("\n\nDecrypted String : " + decryptedString);

            Assert.IsTrue(input == decryptedString);
        }

        [TestMethod]
        public void TestMethod2()
        {
            string input = "have a nice day";
            string encryptedString = Aug12Th2016.Encrypt(input);
            Console.WriteLine("\nEncrypted String : " + encryptedString);

            string decryptedString = Aug12Th2016.Decrypt(encryptedString);
            Console.WriteLine("\n\nDecrypted String : " + decryptedString);

            Assert.IsTrue(input == decryptedString);
        }

        [TestMethod]
        public void TestMethod3()
        {
            string input =
                "In cryptography encryption is the process of encoding messages or information in such a way that only authorized parties can read it";
            string encryptedString = Aug12Th2016.Encrypt(input);
            Console.WriteLine("\nEncrypted String : " + encryptedString);

            string decryptedString = Aug12Th2016.Decrypt(encryptedString);
            Console.WriteLine("\n\nDecrypted String : " + decryptedString);

            Assert.IsTrue(input == decryptedString);
        }

        [TestMethod]
        public void TestMethod4()
        {
            string input = "allthebest";
            string encryptedString = Aug12Th2016.Encrypt(input);
            Console.WriteLine("\nEncrypted String : " + encryptedString);

            string decryptedString = Aug12Th2016.Decrypt(encryptedString);
            Console.WriteLine("\n\nDecrypted String : " + decryptedString);

            Assert.IsTrue(input == decryptedString);
        }

        [TestMethod]
        public void TestMethod5()
        {
            string input = "It is in principle possible to decrypt the message without possessing the key";
            string encryptedString = Aug12Th2016.Encrypt(input);
            Console.WriteLine("\nEncrypted String : " + encryptedString);

            string decryptedString = Aug12Th2016.Decrypt(encryptedString);
            Console.WriteLine("\n\nDecrypted String : " + decryptedString);

            Assert.IsTrue(input == decryptedString);
        }
    }
}

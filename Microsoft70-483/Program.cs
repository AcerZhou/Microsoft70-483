using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft70_483
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Microsoft 70-483!");

            Console.WriteLine("================ Hash Example ======================");

            Hash.HashMethod();

            Console.WriteLine("================ Asymmetric Encryption Example ======================");

            // AsymmetricEncryption.Encrypt();

            Console.WriteLine("================ List Drive Example ======================");

            ListDrive.Show();

            Console.WriteLine("================ Signing And Verify Example ======================");

            //SigningAndVerify.SignAndVerify();

            Console.WriteLine("================ Symmetric Encryption Example ======================");

            SymmetricEncryption.EncryptSomeText();

            Console.WriteLine("================ JavaScript JSON Serialiser Example ======================");

            JavaScriptSeriliserExample.Example();

            Console.WriteLine("================ Data Contract JSON Serialiser Example ======================");

            DataContractJsonSerialiser.Example();

            Console.WriteLine("================ XML Reader Example ======================");

            XmlReaderExample.Read();

            Console.WriteLine("================ XML Writer Example ======================");

            XmlWriterExample.Example();

            Console.WriteLine("================ XML Document Example ======================");

            XmlDocumentExample.Example();

            Console.WriteLine("================ XML Path Example ======================");

            XmlPath.Example();

            Console.WriteLine("================ Regex Check Example ======================");

            RegexMatchPostcodeExample.Example();

            Console.WriteLine("================ IComparable Example ======================");

            IComparableExample.Example();

            Console.ReadLine();
        }
    }
}

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

            Hash.HashMethod();

            // AsymmetricEncryption.Encrypt();

            ListDrive.Show();

            //SigningAndVerify.SignAndVerify();

            SymmetricEncryption.EncryptSomeText();

            XmlReader.Read();

            DataContractJsonSerialiser.Example();

            Console.ReadLine();
        }
    }
}

using System;

namespace Encryption
{
    class Programm
    {
        static void Main(string[] argc)
        {
            Console.Write("Enter a password: ");
            string StringPassword = Console.ReadLine();
            char[] passwordChars = StringPassword.ToCharArray();

            EncryptionPassword encryption = new EncryptionPassword(passwordChars);
            encryption.Encode();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encryption
{
    internal class EncryptionPassword
    {
        protected char[] Password { get; set; }
        private int Key { get; set; }
        
        public EncryptionPassword(char[] password)
        {
            Password = password;
            Key = 4;
        }

        private void OriginalPassword()
        {
            Console.Write("[+] Original password: ");
            for (int i = 0; i < Password.Length; i++)
            {
                Console.Write(Password[i].ToString());
            }
            Console.WriteLine();
        }

        public void Encode()
        {
            int LengthPassword = Password.Length;
            int[] EncodePassword = new int[LengthPassword];
            char Accept = ' ';
            Console.WriteLine("[?] Do you want to watch original password, yes[+] or no[-]?");
            Accept = Convert.ToChar(Console.ReadLine());
            if (Accept == '+')
            {
                OriginalPassword();
            }
            else
            {
                Console.WriteLine("[-] OK");
            }

            for (int i = 0; i < Password.Length; i++)
            {
                EncodePassword[i] = (int)Password[i] + Key;
            }

            Console.Write("[ENCRYPTION] Your encryption password: ");
            for(int i = 0; i < Password.Length; i++)
            {
                Console.Write(((char)EncodePassword[i]).ToString());
            }
            Console.WriteLine();
        }
    }
}

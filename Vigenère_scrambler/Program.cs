using System;
using System.Collections.Generic;

namespace Vigenère_scrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value you want to encrypt(only latin letters a-z): ");
            string valueForEncrypt = Console.ReadLine().ToLower();
            Console.Write("Enter a key(only latin letters a-z): ");
            string key = Console.ReadLine().ToLower();

            int counter = 0;
            if (key.Length < valueForEncrypt.Length)
            {
                for (int i = key.Length; i < valueForEncrypt.Length; i++)
                {
                    key += key[counter];
                    counter++;
                    if (counter == key.Length)
                    {
                        counter = 0;
                    }
                }
            }

            if (key.Length > valueForEncrypt.Length)
            {
                key = key.Substring(0, valueForEncrypt.Length);
            }

            string encryptedValue = VigenèreСipher.Encrypt(valueForEncrypt, key);
            Console.Write($"\n\tHere is what you entered encrypted: {encryptedValue}\n");
        }

    }
}

using System;

namespace Vigenère_scrambler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the value for encryption(only latin letters a-z): ");
            string valueForEncrypt = Console.ReadLine().ToLower();
            Console.Write("\nThe key will be used for encryption, then for decryption.\nEnter a key(only latin letters a-z): ");
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
            string decryptedValue = VigenèreСipher.Decrypt(encryptedValue, key);
            Console.Write($"\n\tHere is your encrypted value: {encryptedValue}");
            Console.Write($"\n\tHere is your decrypted value: {decryptedValue}\n");
        }

    }
}

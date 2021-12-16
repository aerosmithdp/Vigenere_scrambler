

namespace Vigenère_scrambler
{
    class VigenèreСipher
    {
        public static string Encrypt(string valueForEncrypt, string key)
        {
            string result = "";

            for (int i = 0; i < valueForEncrypt.Length; i++)
            {
                int encryptKey = Dictionaries.dictionaryReverse[valueForEncrypt[i]] + Dictionaries.dictionaryReverse[key[i]];
                if (encryptKey > 25)
                {
                    encryptKey -= 26;
                }
                result += Dictionaries.dictionary[encryptKey];
            }
            return result;
        }


        public static string Decrypt(string valueForEncrypt, string key)
        {
            string result = "";

            for (int i = 0; i < valueForEncrypt.Length; i++)
            {
                int decryptedValue = (Dictionaries.dictionaryReverse[valueForEncrypt[i]] - Dictionaries.dictionaryReverse[key[i]]) + 26;
                if (decryptedValue > 25)
                {
                    decryptedValue -= 26;
                }
                result += Dictionaries.dictionary[decryptedValue];
            }
            return result;
        }

    }
}

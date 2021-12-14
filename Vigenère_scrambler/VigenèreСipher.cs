

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
                result = result + Dictionaries.dictionary[encryptKey];
            }
            return result;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class SimpleCipher
{
    private readonly string key;
    private const string alphabet = "abcdefghijklmnopqrstuvwxyz";
    private List<string> alphabetIt = new List<string>();

    public SimpleCipher() : this(RandomString(100))
    {
    }

    public SimpleCipher(string key)
    {
        this.key = key;

        this.alphabetIt = alphabet.ToCharArray().Select(a => a.ToString()).ToList();
    }

    public string Key => key;

    public string Encode(string plaintext)
    {
        var encodedPhrase = new StringBuilder();
        var keyIndex = 0;

        for (int i = 0; i < plaintext.Length; i++)
        {
            // Retrieve current index in alphabet
            var currIndex = alphabetIt.IndexOf(plaintext[i].ToString());

            // Retrieve current index of key in alphabet
            var newIndex = alphabet.IndexOf(this.key[keyIndex]);

            // If new index is out of bounds
            if (currIndex + newIndex <= alphabetIt.Count - 1)
            {
                encodedPhrase.Append(alphabet[currIndex + newIndex]);
            }
            else
            {
                encodedPhrase.Append(alphabet[currIndex + newIndex - alphabetIt.Count]);
            }

            if (keyIndex < this.key.Length - 1)
            {
                keyIndex++;
            }
            else
            {
                keyIndex = 0;
            }
        }

        return encodedPhrase.ToString();
    }

    public string Decode(string ciphertext)
    {
        var decodedPhrase = new StringBuilder();
        var keyIndex = 0;

        for (int i = 0; i < ciphertext.Length; i++)
        {
            // Retrieve current index in alphabet
            var currIndex = alphabetIt.IndexOf(ciphertext[i].ToString());

            // Retrieve current index of key in alphabet
            var newIndex = alphabet.IndexOf(this.key[keyIndex]);

            // If new index is out of bounds
            if (currIndex - newIndex < 0)
            {
                decodedPhrase.Append(alphabet[(alphabetIt.Count) + (currIndex - newIndex)]);
            }
            else
            {
                decodedPhrase.Append(alphabet[currIndex - newIndex]);
            }

            if (keyIndex < this.key.Length - 1)
            {
                keyIndex++;
            }
            else
            {
                keyIndex = 0;
            }
        }

        return decodedPhrase.ToString();
    }

    public static string RandomString(int length)
    {
        var cipherAlphabet = new Random();

        return new string(Enumerable.Repeat(alphabet, length).Select(s => s[cipherAlphabet.Next(s.Length)]).ToArray());
    }
}


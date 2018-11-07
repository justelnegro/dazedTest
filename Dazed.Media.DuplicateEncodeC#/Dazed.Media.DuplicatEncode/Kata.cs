using System.Collections.Generic;
using System.Text;

namespace Dazed.Media.DuplicateEncode
{
    public static class Kata
    {
        public static string DuplicateEncode(string word)
        {
            word = word.ToLower();
            var charFrequency = word.CalculateFrequency();
            return word.EncodeDuplicate(charFrequency);
        }

        public static IDictionary<char,int> CalculateFrequency(this string word)
        {
            var storage = new Dictionary<char, int>(word.Length);
            foreach (var letter in word)
            {
                if (!storage.ContainsKey(letter))
                    storage.Add(letter, 1);
                else
                    storage[letter]++;
            }
            return storage;
        }

        public static string EncodeDuplicate(this string word, IDictionary<char,int> frequency)
        {
            var encoded = new StringBuilder();

            foreach (var letter in word)
            {
                encoded.Append(frequency[letter] == 1 ? '(' : ')');
            }

            return encoded.ToString();
        }
    }
    
}

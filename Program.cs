using System;
using System.Diagnostics;
using System.Linq;

public static class JadenCase
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"{GetVowelCount("abracadabra")}");
    }

    public static int GetVowelCount(string str)
    {
        int vowelCount = 0;
        char[] vowel = { 'a', 'e', 'i', 'o', 'u' };
        char[] _charLenth = str.ToLower().ToCharArray();
        // int result = 0;

        for (int i = 0; i < _charLenth.Length; i++)
        {
            // switch (_charLenth[i])
            // {
            //     case 'a':
            //         vowelCount++;
            //         break;
            //     case 'e':
            //         vowelCount++;
            //         break;
            //     case 'i':
            //         vowelCount++;
            //         break;
            //     case 'o':
            //         vowelCount++;
            //         break;
            //     case 'u':
            //         vowelCount++;
            //         break;
            //     default:
            //         break;
            // }
            vowelCount = _charLenth[i] switch
            {
                'a' => vowelCount + 1,
                'e' => vowelCount + 1,
                'i' => vowelCount + 1,
                'o' => vowelCount + 1,
                'u' => vowelCount + 1,
                _ => vowelCount + 0,
            };
        }

        return vowelCount;
    }
}

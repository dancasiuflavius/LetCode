using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


namespace Exercises
{
    public class Solutions
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> numDict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (numDict.ContainsKey(complement))
                {
                    return new int[] { numDict[complement], i };
                }
                if (!numDict.ContainsKey(nums[i]))
                {
                    numDict.Add(nums[i], i);
                }
            }
            throw new ArgumentException("No two sum solution");
        }
        //public static string IntegerToRoman(int number)
        //{

        //    Dictionary<string, int> cifreRomane = new Dictionary<string, int>
        //{
        //    {"I",1 },
        //    {"IV", 4 },
        //    {"V",5 },
        //    {"IX", 9 },
        //    {"X",10 },
        //    {"XL", 40 },
        //    {"L", 50 },
        //    {"XC", 90 },
        //    {"C", 100 },
        //    {"CD",400 },
        //    {"D",500 },
        //    {"CM",900 },
        //    {"M",1000 }
        //};
        //    int inv = 0;
        //    double power = 10;
        //    double contorCifre = 0;
        //    while (number != 0)
        //    {
        //        int cif = number % 10;
        //        inv = inv * 10 + cif;
        //        contorCifre++;
        //        number = number / 10;
        //    }
        //    string conversie = "";
        //    while (inv != 0)
        //    {

        //        int cifra = inv % 10 * (int)Math.Pow(10, contorCifre - 1);
        //        foreach (var x in cifreRomane)
        //        {

        //            if (cifra == x.Value)
        //            {
        //                conversie = conversie + x.Key;
        //                Console.WriteLine("Flag");
        //            }
        //            else if (cifra > 100 && cifra < 400)
        //            {
        //                conversie = conversie + "C";
        //                while (cifra > 0)
        //                {
        //                    conversie = conversie + x.Key;
        //                    cifra = cifra - 100;
        //                }
        //            }


        //            else if (cifra < 4 && cifra > 1)
        //            {
        //                while (cifra > 0)
        //                {
        //                    conversie = conversie + x.Key;
        //                    cifra--;
        //                }
        //            }
        //            else if (cifra < 9 && cifra > 5)
        //            {
        //                conversie = conversie + "V";
        //                while (cifra > 0)
        //                {
        //                    conversie = conversie + x.Key;
        //                    cifra = cifra - 5;
        //                }
        //            }



        //        }
        //        contorCifre--;
        //        inv = inv / 10;
        //    }
        //    return conversie;
        //}

        public static string IntegerToRoman(int num)
        {
            Dictionary<int, string> romanMap = new Dictionary<int, string>
            {
                { 1000, "M" },
                { 900, "CM" },
                { 500, "D" },
                { 400, "CD" },
                { 100, "C" },
                { 90, "XC" },
                { 50, "L" },
                { 40, "XL" },
                { 10, "X" },
                { 9, "IX" },
                { 5, "V" },
                { 4, "IV" },
                { 1, "I" }
            };

            string romanNumeral = "";

            foreach (var item in romanMap)
            {
                while (num >= item.Key)
                {
                    romanNumeral += item.Value;
                    num -= item.Key;
                }
            }

            return romanNumeral;
        }
        public static int RomanToInteger(string nrRoman)
        {
            Dictionary<char, int> romanMap = new Dictionary<char, int>
            {
                { 'M',1000 },

                { 'D',500 },

                { 'C',100 },

                { 'L', 50 },

                { 'X',10 },

                { 'V',5 },

                { 'I',1 }
            };
            int numar=0;
            for (int i = 0; i < nrRoman.Length; i++)
            {
                if (i < nrRoman.Length - 1 && romanMap[nrRoman[i]] < romanMap[nrRoman[i + 1]])
                {
                    numar -= romanMap[nrRoman[i]];
                }
                else
                {
                    numar += romanMap[nrRoman[i]];
                }
            }

            return numar;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int maxLength = 0, i = 0, j = 0;

            while (i < n && j < n)
            {
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    maxLength = Math.Max(maxLength, j - i);
                }
                else
                {
                    set.Remove(s[i++]);
                }
            }

            return maxLength;
        }
    }
}






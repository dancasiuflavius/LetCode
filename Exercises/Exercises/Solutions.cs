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
        public static bool IsPalindrome(int x)
        {
            if (x < 0)
                return false;

            string s = x.ToString();
            HashSet<char> charSet = new HashSet<char>();

            foreach (char c in s)
            {
                if (!charSet.Contains(c))
                    charSet.Add(c);
                else
                    charSet.Remove(c);
            }

            return charSet.Count <= 1;
        }
        public static string LongestCommonPrefix(string[] strs) // Nu stiu cum sa o fac cu Dictionary sau HashSet
        {
            if (strs == null || strs.Length == 0)
                return "";

            string prefix = strs[0];

            for (int i = 1; i < strs.Length; i++)
            {
                while (strs[i].IndexOf(prefix) != 0)
                {
                    prefix = prefix.Substring(0, prefix.Length - 1);
                    if (prefix == "")
                        return "";
                }
            }

            return prefix;
        }
        //Linked List Cycle???
        /*Given head, the head of a linked list, determine if the linked list has a cycle in it.

        There is a cycle in a linked list if there is some node in the list that can be reached again by continuously following the next pointer. 
        Internally, pos is used to denote the index of the node that tail's next pointer is connected to. Note that pos is not passed as a parameter. */

        public static int MajorityElement(int[] nums)
        {
            HashSet<int> uniqueElements = new HashSet<int>();
            Dictionary<int, int> elementCounts = new Dictionary<int, int>();

            // folosim HashSet si adaugam doar elementele unice. HashSet permite doar elemente unice.
            foreach (int num in nums)
            {
                uniqueElements.Add(num);
            }

            // Numaram frecventa la fiecare element unic
            foreach (int element in uniqueElements)
            {
                int count = 0;
                foreach (int num in nums)
                {
                    if (num == element)
                    {
                        count++;
                    }
                }
                elementCounts[element] = count;
            }

            // Facem maximul
            int majorityElement = nums[0]; // Initialize with any value
            int maxCount = 0;

            foreach (var x in elementCounts)
            {
                if (x.Value > maxCount)
                {
                    maxCount = x.Value;
                    majorityElement = x.Key;
                }
            }

            return majorityElement;
        }
        #region
        public static bool IsHappy(int n)
        {
            HashSet<int> seen = new HashSet<int>();

            while (n != 1 && !seen.Contains(n))
            {
                seen.Add(n);
                n = SumaPatrate(n);
            }

            return n == 1;
        }

        public static int SumaPatrate(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                int cif = n % 10;
                sum += cif * cif;
                n /= 10;
            }
            return sum;
        }
        #endregion

        public static bool ContainsDuplicate(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                if (set.Contains(num))
                {
                    return true; // Am gasit dublura
                }
                else
                {
                    set.Add(num);
                }
            }

            return false; 
        }
        public static bool IsAnagram(string s, string t)// ????
        {
            if (s.Length != t.Length)
                return false;

            Dictionary<char, int> charFrequency = new Dictionary<char, int>();

           
            foreach (char c in s)
            {
                if (!charFrequency.ContainsKey(c))
                    charFrequency[c] = 1;
                else
                    charFrequency[c]++;
            }
            return true;//am pusa asa doar 
            
        }
        public static int MissingNumber(int[] nums)
        {
            HashSet<int> set = new HashSet<int>();

            foreach (int num in nums)
            {
                set.Add(num);
            }

            int n = nums.Length + 1; 
            for (int i = 0; i < n; i++)
            {
                if (!set.Contains(i))
                {
                    return i;
                }
            }
            return n;
        }
        //290. Word Pattern ???
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> set1 = new HashSet<int>(nums1);
            HashSet<int> set2 = new HashSet<int>(nums2);

           
            set1.IntersectWith(set2);

           
            int[] intersection = new int[set1.Count];
            set1.CopyTo(intersection);

            return intersection;
        }
    }
}






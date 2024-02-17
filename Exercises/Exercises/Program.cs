using Exercises;

public class Program
{
    private static void Main(string[] args)
    {
        /*PROBLEMA 1 TWOSUM*/
        //int[] nums1 = { 2, 7, 11, 15 };
        //int target1 = 9;
        //int[] result1 = Solutions.TwoSum(nums1, target1);
        //Console.WriteLine($"[{result1[0]}, {result1[1]}]");

        //int[] nums2 = { 3, 2, 4 };
        //int target2 = 6;
        //int[] result2 = Solutions.TwoSum(nums2, target2);
        //Console.WriteLine($"[{result2[0]}, {result2[1]}]");

        //int[] nums3 = { 3, 3 };
        //int target3 = 6;
        //int[] result3 = Solutions.TwoSum(nums3, target3);
        //Console.WriteLine($"[{result3[0]}, {result3[1]}]");

        //int number = 55;
        //string romanNumeral = Solutions.IntegerToRoman(number);
        //Console.WriteLine($"{number} in Roman numerals is {romanNumeral}");
        //string s = "abcdefghija"; // Example string
        //int length = Solutions.LengthOfLongestSubstring(s);
        //Console.WriteLine("Length of the longest substring without repeating characters: " + length);
        string s1 = "III";
        string s2 = "LVIII";
        string s3 = "MCMXCIV";

        Console.WriteLine("Input: " + s1 + ", Output: " + Solutions.RomanToInteger(s1));
        Console.WriteLine("Input: " + s2 + ", Output: " + Solutions.RomanToInteger(s2));
        Console.WriteLine("Input: " + s3 + ", Output: " + Solutions.RomanToInteger(s3));
    }
}
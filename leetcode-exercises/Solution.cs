using System;

namespace Program
{
    class Solution
    {
        //Palindrome Number
        //Gives a int number and verifys if it is a palindrome (returns true else false)
        public bool IsPalindrome(int x)
        {
            string num = x.ToString();
            string numPalindrome = "";
            int count = (num.Length - 1);
            for (int i = 0; i <= count; count--)
            {
                numPalindrome += num[count];
            }
            if (numPalindrome.Equals(num))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Roman to Integer
        //Gives a string like "III" and returns the sum converting Roman Numbers
        public int RomanToInt(string s)
        {
            Dictionary<char, int> dicionario = new Dictionary<char, int>{
            {'I', 1},
            {'V', 5},
            {'X', 10},
            {'L', 50},
            {'C', 100},
            {'D', 500},
            {'M', 1000}
        };
            int sum = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int currentValue = dicionario[s[i]];
                int nextValue = (i < (s.Length - 1)) ? dicionario[s[i + 1]] : 0;
                if (currentValue < nextValue)
                {
                    sum -= currentValue;
                }
                else
                {
                    sum += currentValue;
                }

            }
            return sum;
        }
    }
}
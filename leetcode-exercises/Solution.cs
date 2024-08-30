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
    }
}
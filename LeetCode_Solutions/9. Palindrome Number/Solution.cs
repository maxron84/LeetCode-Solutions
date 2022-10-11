namespace LeetCode_Solutions._9._Palindrome_Number
{
    public static class Solution
    {
        public static bool IsPalindromeNumber(int candidate = 121)
        {
            if (candidate < 0)
                return false;

            var reversed = 0;
            var original = candidate;

            while (candidate != 0)
            {
                var remainder = candidate % 10;
                reversed = reversed * 10 + remainder;
                candidate /= 10;
            }

            if (reversed != original)
                return false;
            
            return true;
        }
    }
}

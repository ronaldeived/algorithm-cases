using System;
namespace Main.ProblemSolving.WordsPalindromics
{
    public static class Palindromics
    {
        public static string GetPalindromics(string word)
        {
            string? result = LongestPalindrome(word);

            if (result != null && result.Length > 2)
            {
                return result;
            }
            else
            {
                return "none";
            }
        }

        private static string? LongestPalindrome(string s)
        {
            if (string.IsNullOrEmpty(s)) return null;

            string longest = s.Substring(0, 1);

            for (int i = 0; i < s.Length; i++)
            {
                // Teste com i como ponto central
                string temp = ExpandAroundCenter(s, i, i);
                if (temp.Length > longest.Length)
                {
                    longest = temp;
                }

                // Teste com i e i+1 como pontos centrais
                temp = ExpandAroundCenter(s, i, i + 1);
                if (temp.Length > longest.Length)
                {
                    longest = temp;
                }
            }
            return longest;
        }

        private static string ExpandAroundCenter(string s, int left, int right)
        {
            while (left >= 0 && right < s.Length && s[left] == s[right])
            {
                left--;
                right++;
            }
            return s.Substring(left + 1, right - left - 1);
        }
    }
}


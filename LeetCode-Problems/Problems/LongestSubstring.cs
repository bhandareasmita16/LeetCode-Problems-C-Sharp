using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode_Problems.Problems
{
    internal class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
          
            Dictionary<char, int> dict = new Dictionary<char, int>();
            int maxLength = 0;
            int left = 0;
            for (int i = 0; i < s.Length; i++)
            {
                
                char c = s[i];
                if (dict.ContainsKey(c) && dict[c] >= left)
                {
                    left = dict[c] + 1;
                }

                dict[c] = i;
                maxLength = Math.Max(maxLength, i - left + 1);

            }
            return maxLength;
        }
    }
}

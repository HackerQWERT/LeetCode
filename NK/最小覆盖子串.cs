
// using System.Collections.Generic;
// using System.Linq;

// public class Solution
// {
//     //  你一个字符串 s 、一个字符串 t 。返回 s 中涵盖 t 所有字符的最小子串。如果 s 中不存在涵盖 t 所有字符的子串，则返回空字符串 "" 。

//     public string MinWindow(string s, string t)
//     {
//         int left = 0;
//         int right = 0;
//         int start = 0;
//         int minLen = int.MaxValue;
//         int valid = 0;
//         Dictionary<char, int> need = new Dictionary<char, int>();
//         Dictionary<char, int> window = new Dictionary<char, int>();
//         foreach (var c in t)
//         {
//             if (need.ContainsKey(c))
//                 need[c]++;
//             else
//                 need.Add(c, 1);
//         }

//         while (right < s.Length)
//         {
//             //移动右指针直到窗口包含所有所需的字符
//             char c = s[right];
//             right++;
//             if (need.ContainsKey(c))
//             {
//                 if (window.ContainsKey(c))
//                     window[c]++;
//                 else
//                     window.Add(c, 1);
//                 if (window[c] == need[c])
//                     valid++;
//             }
//             while (valid == need.Count)
//             {
//                 //移动左指针直到窗口不包含所有所需的字符
//                 if (right - left < minLen)
//                 {
//                     start = left;
//                     minLen = right - left;
//                 }
//                 char d = s[left];
//                 left++;
//                 if (need.ContainsKey(d))
//                 {
//                     if (window[d] == need[d])
//                         valid--;
//                     window[d]--;
//                 }
//             }

//         }
//         return minLen == int.MaxValue ? "" : s.Substring(start, minLen);

//     }
// }

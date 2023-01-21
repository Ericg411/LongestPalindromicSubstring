using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestPalindromicSubstring
{
    internal class Program
    {
        //Given a string s, return the longest palindromic substring in s.
        static void Main(string[] args)
        {
            Console.WriteLine($"Expected: 'bab' OR 'aba', Got: {LongestPalindrome("babad")}");
            Console.WriteLine($"Expected: 'bb', Got: {LongestPalindrome("cbbd")}");
            Console.WriteLine($"Expected: 'bghuuhgb', Got: {LongestPalindrome("bghufdsibgihufdbsgfuidsbghuuhgbifdsbhguifdsjbikfogldsj")}");
        }

        public static string LongestPalindrome(string s)
        {
            List<char> reverseString = new List<char>();
            List<string> palindromes = new List<string>();

            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverseString.Add(s[i]);
            }
            var firstReversal = new string(reverseString.ToArray());
            if (s == firstReversal)
            {
                return s;
            }
            else
            {
                reverseString.Clear();
            }

            for (int i = 0; i <= s.Length - 1; i++)
            {
                var counter = i + 1;
                int firstIndex;
                int secondIndex;
                if (counter >= s.Length)
                {
                    break;
                }
                else
                {
                    if (s[i] == s[counter])
                    {
                        while (s[i] == s[counter])
                        {
                            if (counter == s.Length - 1)
                            {
                                counter++;
                                break;
                            }
                            counter++;
                        }
                        counter -= 1;
                        firstIndex = i;
                        secondIndex = counter;
                        i = counter;

                        while (firstIndex != 0 && secondIndex != s.Length - 1)
                        {
                            if (s[firstIndex - 1] == s[secondIndex + 1])
                            {
                                firstIndex--;
                                secondIndex++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        palindromes.Add(s.Substring(firstIndex, (secondIndex - firstIndex + 1)));

                    }
                    else
                    {
                        firstIndex = i;
                        secondIndex = i;
                        while (firstIndex != 0 && secondIndex != s.Length - 1)
                        {
                            if (s[firstIndex - 1] == s[secondIndex + 1])
                            {
                                firstIndex--;
                                secondIndex++;
                            }
                            else
                            {
                                break;
                            }
                        }

                        if (firstIndex != secondIndex)
                        {
                            palindromes.Add(s.Substring(firstIndex, (secondIndex - firstIndex + 1)));
                        }
                    }
                }
            }

            if (palindromes.Count == 0)
            {
                palindromes.Add(s[0].ToString());
            }

            List<string> results = new List<string>();

            foreach (string l in palindromes.OrderBy(x => x.Length))
            {
                results.Add(l);
            }

            return results[results.Count - 1];
        }
    }
}

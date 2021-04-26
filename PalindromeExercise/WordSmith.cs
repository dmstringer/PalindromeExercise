using System;
using System.Collections.Generic;
using System.Text;

namespace PalindromeExercise
{
    public class WordSmith
    {
        public bool IsAPalindrome(string theWord)
        {
            int min = 0;
            int max = theWord.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = theWord[min];
                char b = theWord[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
    }
}

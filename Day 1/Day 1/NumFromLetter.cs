using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2022
{
    public class NumFromLetter
    {
        public static int NumFromLetters(char ch)
        {
            if (ch >= 'a' && ch <= 'z') ch -= (char)('a' - 1);
            else
                if (ch >= 'A' && ch <= 'Z')
            {
                ch -= (char)('A' - 1);
                int n = ch;
                ch = (char)(n + 26);
            }
            else ch = '\0'; // all other characters use binary zero
            return (int)ch;
        }
    }
}

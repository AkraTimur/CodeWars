using System;
using System.Collections.Generic;
using System.Text;

// Testing 1-2-3

namespace CodeWars
{
    public class LineNumbering
    {
        public static List<string> Number(List<string> lines)
        {
            string [] array = lines.ToArray();
            for (int i = 0; i < array.Length; i++ )
            {
                array[i] = (i+1).ToString() + ": " + array[i];
            }
            List<string> result = new List<string>(array);
            return result;
        }
    }
}


 /* Your team is writing a fancy new text editor and you've been tasked with implementing the line numbering.

Write a function which takes a list of strings and returns each line prepended by the correct number.

The numbering starts at 1. The format is n: string.Notice the colon and space in between.
 */
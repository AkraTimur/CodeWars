using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abbreviate_a_Two_Word_Name
{
    public class Kata
    {
        public static string AbbrevName(string name)
        {
            string[] array = name.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstName = array[0];
            string secondName = array[1];

            return $"{firstName[0]}.{ secondName[0] }".ToUpper();
        }
    }
}

//Write a function to convert a name into initials. This kata strictly takes two words with one space in between them.

//The output should be two capital letters with a dot separating them.

//It should look like this:

//Sam Harris => S.H

//patrick feeney => P.F
//https://www.codewars.com/kata/57eadb7ecd143f4c9c0000a3/train/csharp

//public static string AbbrevName(string name) => string.Join(".", name.Split(' ').Select(w => w[0])).ToUpper();
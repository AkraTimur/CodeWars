using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Lario_and_Muigi_Pipe_Problem
{
    public class Fixer
    {
        public static int Length { get; private set; }

        public static List<int> PipeFix(List<int> numbers)
        {
            List<int> res = new List<int>();
            int oneNum = numbers.First();
            int twoNum = numbers.Last();

            for (int i = oneNum; i <= twoNum; i++)
            {
                res.Add(i);
            }
            return res;
        }
    }
}

// alternative     return Enumerable.Range(numbers.First(), numbers.Last() - numbers.First() + 1).ToList();

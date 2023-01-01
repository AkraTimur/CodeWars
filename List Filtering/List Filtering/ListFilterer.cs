using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Filtering
{
    public class ListFilterer
    {
        public static IEnumerable<int> GetIntegersFromList(List<object> listOfItems)
        {
            var listOfIntegers = new List<int>();
            foreach (var item in listOfItems) 
            {
                if(item is int) 
                {
                    listOfIntegers.Add((int)item);
                }
            }
            return listOfIntegers;
        }
    }
}

//=> listOfItems.OfType<int>();

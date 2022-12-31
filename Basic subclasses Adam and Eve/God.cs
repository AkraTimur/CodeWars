using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_subclasses_Adam_and_Eve
{
    public class God
    {
        public static Human[] Create()
        {
            Human[] array = new Human[2];
            array[0] = new Man();
            array[1] = new Woman();
            return array;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public  class Game
    {/// <summary>
     /// Grasshopper - Terminal game move function.  
     /// </summary>
     /// <param name="position"></param>
     /// <param name="roll"></param>
     /// <returns></returns>
        public static int Move(int position, int roll)
        {
            return position + (roll * 2);
        }
        /*In this game, the hero moves from left to right. The player rolls the dice and moves the number of spaces indicated by the dice two times.
          Create a function for the terminal game that takes the current position of the hero and the roll (1-6) and return the new position.
         */
    }
}

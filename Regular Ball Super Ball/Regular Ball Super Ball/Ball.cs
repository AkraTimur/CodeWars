using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regular_Ball_Super_Ball
{
    public class Ball
    {
        public string ballType { get; set; }

        public Ball(string ballType = "regular")
        {
            this.ballType = ballType;
        }
    }
}

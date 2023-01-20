using System;
using System.Drawing;

namespace Color_Ghost
{
    public class Ghost
    {
        private string color;
        private string[] _colors = { "white", "yellow", "purple", "red" };

        public Ghost()
        {
            Random random = new Random();
            color = _colors[random.Next(0, _colors.Length)];
        }

        public string GetColor()
        {
            return color;
        }
    }
}

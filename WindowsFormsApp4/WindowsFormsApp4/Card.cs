using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Card
    {
        private string color;
        private int value;

        public Card(string c, int v)
        {
            color = c;
            value = v;
        }

        public string getColor()
        {
            return color;
        }
        public int getValue()
        {
            return value;
        }
        public string getImageName()
        {
            return color + value;
        }
    }
}

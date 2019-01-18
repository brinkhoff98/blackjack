using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    public class Myrandom
    {
        public int Newrandom(int cardcount)
        {
            Random random = new Random();
            
            return random.Next(0, (cardcount + 1));
        }
    }
}

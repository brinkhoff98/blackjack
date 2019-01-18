using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Deck 
    {
        Myrandom randomnummer = new Myrandom();
        public Deck()
        {
            randomnummer.Newrandom();
        }
    }
}

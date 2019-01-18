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
        list myList = new list();

        public Deck()
        {
            int raknad = myList.Count();
            int nummer1 = randomnummer.Newrandom(raknad);
            myList.RemoveAt(nummer1);
        }
    }
}

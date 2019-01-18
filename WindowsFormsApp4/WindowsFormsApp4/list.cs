using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class list
    {
        List<Card> minLista = new List<Card>();

        public Card Drawcard(int nummer)
        {
            return minLista[nummer];
        }
        public int Count()
        {
            return minLista.Count;
        }
        public void RemoveAt(int nummer)
        {
            minLista.RemoveAt(nummer);
        }
    }
}

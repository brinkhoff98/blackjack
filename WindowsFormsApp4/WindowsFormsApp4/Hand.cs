using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Hand
    {
        List<Card> myHand = new List<Card>();

        public Hand(Card drawnCard)
        {
            myHand.Add(drawnCard);
        }
        public List<Card> getHand()
        {
            return myHand;
        }
    }
}

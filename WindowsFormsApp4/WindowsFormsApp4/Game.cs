using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp4
{
    class Game
    {
        int Dealerscore = 0;
        int Playerscore = 0;

        public Card Drawcard()
        {
            Mycard = Deck.GetCard();
            return Mycard;
        }

        public bool Checkscore()
        {
            if (Playerscore > Dealerscore)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Addscoreplayer(Mycard)
        {
            Playerscore += Mycard.number;
        }
        public void Addscoredealer(Mycard)
        {
            Dealerscore += Mycard.number;
        }
    }
}

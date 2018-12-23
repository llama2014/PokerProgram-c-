using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poker
{
    //using Poker;
    using System;

    public class Hand
    {
        public Hand()
        {
            Random r = new Random();

            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    cards[i] = new Card(r);
                    if (containedCard(cards[i], cards, i)) continue;
                    break;

                }
            }
        }

        public Hand(string handText)
        {
            cardsFromString(handText);
        }

        public Hand(string handText, string holdString)
        {
            cardsFromString(handText);
            holdCards(holdString);
            draw();
        }

        public Hand(Hand hand, string holdString)
        {
            this.cards = hands.cards;
            holdCards(holdString);
            draw();
        }

        public int Score
        {
            get
            {
                if (score < 0) calcScore();
                return score;

            }
        }

        public string Title
        {
            get
            {
                return titles[Score];
            }

        }

        public string cardName(int cardNum)
        {
            return cards[cardNum - 1].Name;
        }


    }
}

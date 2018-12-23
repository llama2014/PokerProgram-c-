using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Poker
{

    using System;

    internal class Card
    {
        public Card() : this(new Random()) { }

        public Card(Random r)
        {
            Number = r.Next(2, 15);
            Suit = r.Next(1, 5);
            Name = numberArray[Number - 2] + suitArray[Suit - 1];

        }

        public Card(string name)
        {
            string n = name.Substring(0, 1);
            string s = name.Substring(1, 1);
            Number = numberString.IndexOf(n) + 2;
            Suit = suitString.IndexOf(s) + 1;
            Name = name;

        }



        public readonly int Number;
        public readonly int Suit;
        public readonly string Name;

        public override string ToString()
        {
            return Name;
        }

        public override bool Equals(object obj)
        {
            try
            {
                Card c = (Card)obj;
                return c.Number == Number && c.Suit == Suit;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public override int GetHashCode()
        {
            return (Suit << 4) + Number;

        }

        // beginning of private fields

        private static string[] numberArray = { "2", "3", "4", "5", "6", "7", "8", "9", "T", "J", "Q", "K", "A" };

        private static string[] suitArray = { "C", "D", "H", "S" };

        private static string numberString = "23456789TJQKA";

        private static string suitString = "CDHS";
    }

}

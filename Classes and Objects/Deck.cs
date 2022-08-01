using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    public class Deck
    {
        public Deck() { 
        
            Cards = new List<Card>();
            List<String> Suits = new List<string> () { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<String> Faces = new List<string>() { 
                "Tow", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten","Jack","Queen","King","Ace"
            };

            foreach (string Face in Faces) {
                foreach (string Suit in Suits) { 
                    Card card = new Card();
                    card.Suit = Suit;
                    card.Face = Face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}

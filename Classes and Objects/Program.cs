using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_and_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TwentyOneGame game = new TwentyOneGame();
            //game.Players = new List<string> { "Jesse", "Bill", "Joe" };
            //game.listPlayers();
            //game.Play();
            //Console.ReadLine();


            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach(Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " Of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();

            //Card cardOne = new Card();
            //cardOne.Face = "Queen";
            //cardOne.Suit = "Spades";

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit);
            //Console.ReadLine();
   
        }
  
    }
}

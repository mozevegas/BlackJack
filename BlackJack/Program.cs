using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // testing proof of concept
            Console.WriteLine("Hello");
            var card1 = new Card(Suit.Hearts, Rank.King);  
            Console.WriteLine(card1);

            // build deck
            var deck = new List<Card>();

            foreach (Rank r in Enum.GetValues(typeof(Rank)))
            {
                foreach (Suit s in Enum.GetValues(typeof(Suit)))
                {
                    deck.Add(new Card(s, r));
                }
            }

            // shuffle deck
            //sort the deck. NOTICE that the variable 'deck' is unchanged, but 'randomDeck' is the actual sorted deck.
            var randomDeck = deck.OrderBy(x => Guid.NewGuid()).ToList();
            var userHand = new List<Card>();

            Console.WriteLine("The deck is shuffled");

            // Game starts here

            // pick first value from the randomDeck
            
            Console.WriteLine($"This is a random card: {randomDeck[0]}");
            userHand.Add(randomDeck[0]);
            randomDeck.RemoveAt(0);
            userHand.Add(randomDeck[0]);
            randomDeck.RemoveAt(0);

            Console.WriteLine($"user hand{userHand[0]}");

            foreach (var x in userHand)
            {
                Console.WriteLine(x);
            }

            // create a List to contain all the 

            // 2 while loops exist
            // for player, runs while less than 5 cards picked and cardamount is less than 21
            // for computer, runs while less than 5 cards and cardamount is less than 16

            // Method to compare values and declare winner



        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    class Program
    {
        static void PickCard (List<Card> userHand, List<Card> randomDeck)
        {
            userHand.Add(randomDeck[0]);
            randomDeck.RemoveAt(0);
        }

        static void AddBorder()
        {
            Console.WriteLine("       ");
            Console.WriteLine("*****************************************************");
            Console.WriteLine("       ");
        }

        static void Main(string[] args)
        {
            
            // testing proof of concept
            //var card1 = new Card(Suit.Hearts, Rank.King);  
            //Console.WriteLine(card1);

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

            // creating List called userHand for card verbiage and List for value
            var userHand = new List<Card>();
            var userValue = new List<int>();

            var dealerHand = new List<Card>();
            var dealerValue = new List<int>();

            // Greeting
            AddBorder();
            Console.WriteLine("       Would you like to play a game of BlackJack?");
            Console.WriteLine("       ");
            Console.WriteLine("       Answer y for YES, and n for NO.");
            var startGame = Console.ReadLine();
            if (startGame == "y")
            {
                Console.WriteLine("       Yes is a great answer.");
                Console.ReadKey();
                Console.Clear();
            }

            AddBorder();
            // testing throughput of response
            Console.WriteLine($"       You have chosen NOT to play... {startGame}");
            Console.WriteLine("       Press the spacebar for good luck...");
            Console.ReadKey ();
            AddBorder();
            Console.WriteLine("       You have shuffled the deck.");
            AddBorder();

            // Game starts here
            Console.WriteLine("       Press the spacebar to begin this game...");
            Console.ReadKey();
            Console.Clear();
            // pick first value from the randomDeck

            //Console.WriteLine($"This is a random card: {randomDeck[0]}");
            //Console.WriteLine($"It is worth {randomDeck[0].GetCardValue()} points.");

            // first 4 cards of deck will always be dealt, Alternating btw
            userHand.Add(randomDeck[0]);
            userValue.Add(randomDeck[0].GetCardValue());
            randomDeck.RemoveAt(0);
            dealerHand.Add(randomDeck[0]);
            dealerValue.Add(randomDeck[0].GetCardValue());
            randomDeck.RemoveAt(0);
            userHand.Add(randomDeck[0]);
            userValue.Add(randomDeck[0].GetCardValue());
            randomDeck.RemoveAt(0);
            dealerHand.Add(randomDeck[0]);
            dealerValue.Add(randomDeck[0].GetCardValue());
            randomDeck.RemoveAt(0);

            AddBorder();
            Console.WriteLine("       These cards are in your hand:");
            foreach (var cardy in userHand)
            {
                Console.WriteLine($"       {cardy}");
            }
            //Console.WriteLine(userHand[0].GetCardValue);
            //public int GetHandTotal(List<Card> hand)*********************

            var playerPoints = 0;
                foreach (var nuzz in userHand)
                {
                    playerPoints += nuzz.GetCardValue();
                }
                Console.WriteLine($"       Total points: {playerPoints} points");
            AddBorder();
            Console.WriteLine("       Press the spacebar to continue");
            Console.ReadKey();
            AddBorder();
            // TEMPORARY - Return Dealer's Cards all
            Console.WriteLine("       The dealer shows ONE of his cards:");
            foreach (var dealcards in dealerHand)
            {
                Console.WriteLine($"       {dealcards}");
            }
            var dealpoints = 0;
            foreach(var dealvalue in dealerHand)
            {
                dealpoints += dealvalue.GetCardValue();
            }
            Console.WriteLine($"       Dealer has {dealpoints}");

            AddBorder();
            Console.WriteLine("       Would you like to hit? (I hope you don't bust)");
            Console.WriteLine("       Please enter h for Hit Me.");
            var hitMe = Console.ReadLine();
            if (hitMe == "h")
            {
                // draw card for player and then delete that card from List
                // add those values up. if they are over 21, game over
                // if not ask if player wants another card.
                Console.WriteLine("       You shall be dealt another card.");
                Console.ReadKey();
            }
            AddBorder();
            Console.WriteLine("       The dealer will now play...");
            Console.WriteLine("       (Press the spacebar to see your fate)");
            Console.ReadKey();

            // Dealer loop to draw card until he goes over 21

            while (dealpoints < 16 )
            {
                dealerHand.Add(randomDeck[0]);
                dealerValue.Add(randomDeck[0].GetCardValue());
                randomDeck.RemoveAt(0);
                dealpoints = 0;
                foreach (var dealvalue in dealerHand)
                {
                    dealpoints += dealvalue.GetCardValue();
                }
                Console.WriteLine($"       testing value of dealer: {dealpoints}");
            }
            //Console.Clear();
            AddBorder();
            Console.WriteLine($"       The dealer shows: {dealpoints}");
            Console.WriteLine($"       You have {playerPoints} points.");

            if (dealpoints > 21)
            {
                Console.WriteLine("       The dealer has BUSTED!!");
                dealpoints = 0;
            }

            if (playerPoints > dealpoints)
            {
                Console.WriteLine("       YOU HAVE WON!!!");
            }
            else
            {
                Console.WriteLine("       Sorry, you have lost your life savings.. :( ");
            }

            Console.WriteLine("       Thank you for playing.");
            AddBorder();

            // figure Value of Dealer Hand
            //dealpoints = 0;
            //foreach (var dealvalue in dealerHand)
            //{
            //    dealpoints += dealvalue.GetCardValue();
            //}
            //Console.WriteLine($"       Dealer has {dealpoints}");

            //if (dealpoints > 21)
            //{
            //    Console.WriteLine("       The Dealer has busted.");
            //}
            //else if (22 > dealpoints ||  dealpoints >= 16)
            //{
            //    Console.WriteLine($"       The Dealer stands at {dealpoints}");
            //}


            Console.ReadKey();



            // **************************************************************

            // 2 while loops exist
            // for player, runs while less than 5 cards picked and cardamount is less than 21
            // for computer, runs while less than 5 cards and cardamount is less than 16

            // Method to compare values and declare winner



        }
    }
}

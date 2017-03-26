﻿using System;
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

            // creating List called userHand
            var userHand = new List<Card>();

            Console.WriteLine("The deck is shuffled");
            Console.WriteLine("-------------");
            // Game starts here

            // pick first value from the randomDeck
            
            Console.WriteLine($"This is a random card: {randomDeck[0]}");

            // adds first value from randomDeck
            userHand.Add(randomDeck[0]);

            // deletes top card from randomDeck
            randomDeck.RemoveAt(0);

            // repeat
            //userHand.Add(randomDeck[0]);
            //randomDeck.RemoveAt(0);

            // repeat
            userHand.Add(randomDeck[0]);
            randomDeck.RemoveAt(0);



            Console.WriteLine($"This displays First? Card: {userHand[0]}");


            // This 
            Console.WriteLine("This is not a card...");
            //var tempo = (userHand[2]);
            Console.WriteLine(userHand[0]);


            Console.WriteLine("These cards are in your hand:");
            foreach (var cardy in userHand)
            {
                Console.WriteLine(cardy);
            }

            //Console.WriteLine(userHand[0].GetCardValue);

            //public int GetHandTotal(List<Card> hand)*********************
            //{
                var plz = 0;
                foreach (var nuzz in userHand)
                {
                    plz += nuzz.GetCardValue();
                }
                Console.WriteLine($"Total points: {plz} points");
                Console.WriteLine(" ");
            //return plz;
            //}

            // **************************************************************
            //this is getting your card hand value  

            List<int> cardValue = new List<int>();
            foreach (Card cardzz in userHand)
            {
                cardValue.Add(cardzz.GetCardValue());
            }
            //this will display the value of the cards in the hand.
            Console.WriteLine(cardValue.Sum(x => Convert.ToInt32(x)));

            //############################################################

            //GetHandTotal(userHand);

            //attempting to get the value of a card
            // int Card; GetCardValue();

            // var flopo = new Card(rv.10);
            //Console.WriteLine(flopo);


            // create a List to contain all the 

            // 2 while loops exist
            // for player, runs while less than 5 cards picked and cardamount is less than 21
            // for computer, runs while less than 5 cards and cardamount is less than 16

            // Method to compare values and declare winner



        }
    }
}

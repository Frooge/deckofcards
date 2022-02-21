using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    public class App
    {
        //List
        private List<CardClass> deck = new List<CardClass>();
        
        private static Random rng = new Random();

        public App()
        {
        }

        public string Choice()
        {
            Console.Write("\nDeck of Cards\n" +
                "1 - Create\n" +
                "2 - Shuffle\n" +
                "3 - Deal\n" +
                "4 - Display Deck\n" +
                "Choice: ");
            return Console.ReadLine();
        }

        public void CreateDeck()
        {
            deck.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(Suits)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Rank)).Length; j++)
                {
                    deck.Add(new CardClass(((Suits)i).ToString(), ((Rank)j).ToString()));
                }
            }
            Console.WriteLine("New deck created!");
        }

        public void ShuffleDeck()
        {
            if(deck.Count > 0)
            {
            var tempCards = new CardClass();
            Console.WriteLine("Deck not yet shuffled!");
            int n = deck.Count;
            while(n>1){
                n--;
                int k = rng.Next(n+1);
                tempCards = deck[k];
                deck[k] = deck[n];
                deck[n] = tempCards;
            }
            Console.WriteLine("Deck shuffled!");
            }
            else
            {
                Console.WriteLine("Deck is empty!");
            }
        }

        public void DisplayDeck()
        {
            if(deck.Count > 0)
            {
                foreach (CardClass card in deck)
                {
                    Console.WriteLine("Suit: " + card.suit + "; Rank: " + card.rank);
                }
            }
            else
            {
                Console.WriteLine("Deck is empty!");
            }
            Console.WriteLine("No. of cards: " + deck.Count);

        }

        public void Deal(int num)
        {
            if(deck.Count > 0)
            {            
                while(num>0){
                    Console.WriteLine("Suit: " + deck[0].suit + "; Rank: " + deck[0].rank);    
                    deck.RemoveAt(0);
                    num--;
                }
            }
            else
            {
                Console.WriteLine("Cannot deal if deck has less cards than the asked number.");
            }
        }
    }
}

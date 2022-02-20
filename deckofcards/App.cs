using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    public class App
    {
        //List
        private List<CardClass> cards = new List<CardClass>();
        
        private static Random rng = new Random();

        public App()
        {
        }

        public string Choice()
        {
            Console.Write("\nDeck of Cards\n" +
                "1 - Create\n" +
                "2 - Shuffle\n" +
                "3- Deal\n" +
                "4 - Display Deck\n" +
                "Choice: ");
            return Console.ReadLine();
        }

        public void CreateDeck()
        {
            cards.Clear();
            for (int i = 0; i < Enum.GetNames(typeof(Suits)).Length; i++)
            {
                for (int j = 0; j < Enum.GetNames(typeof(Rank)).Length; j++)
                {
                    cards.Add(new CardClass(((Suits)i).ToString(), ((Rank)j).ToString()));
                }
            }
            Console.WriteLine("New deck created!");
        }

        public void ShuffleDeck()
        {
            if(cards.Count > 0)
            {
            var tempCards = new CardClass("","");
            Console.WriteLine("Deck not yet shuffled!");
            int n = cards.Count;
            while(n>1){
                n--;
                int k = rng.Next(n+1);
                tempCards = cards[k];
                cards[k] = cards[n];
                cards[n] = tempCards;
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
            if(cards.Count > 0)
            {
                foreach (CardClass card in cards)
                {
                    Console.WriteLine("Suit: " + card.suit + "; Rank: " + card.rank);
                }
            }
            else
            {
                Console.WriteLine("Deck is empty!");
            }
            Console.WriteLine("No. of cards: " + cards.Count);

        }

        public void Deal(int num)
        {
            if(cards.Count > 0)
            {            
                while(num>0){
                    Console.WriteLine("Suit: " + cards[0].suit + "; Rank: " + cards[0].rank);    
                    cards.RemoveAt(0);
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

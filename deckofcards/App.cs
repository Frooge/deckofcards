using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    public class App
    {
        //List
        private List<CardClass> cards = new List<CardClass>();

        public App()
        {
        }

        public string Choice()
        {
            Console.WriteLine("Deck of Cards\n" +
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
            //Add code in here...
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

        }

        public void Deal(int num)
        {
            //Add code in here...
        }
    }
}

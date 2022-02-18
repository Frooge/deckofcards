using System;
using System.Collections.Generic;
using System.Text;

namespace deckofcards
{
    public class App
    {
        //List

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
            
        }

        public void ShuffleDeck()
        {
            //Add code in here...
        }

        public void DisplayDeck()
        {
            //Add code in here...
        }

        public void Deal(int num)
        {
            //Add code in here...
        }
    }
}

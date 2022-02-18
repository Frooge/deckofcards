using System;

namespace deckofcards
{
    class Program
    {
        static void Main(string[] args)
        {
            App app = new App();
            //Add code in here...

            while(true)
            {
                switch(app.Choice())
                {
                    case "1":
                        app.CreateDeck();
                        break;
                    case "2":

                        break;
                    case "3":

                        break;
                    case "4":
                        app.DisplayDeck();
                        break;
                    default:
                        Console.WriteLine("Not a valid choice");
                        break;
                }
            }
        }
    }
}

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
                        app.ShuffleDeck();
                        break;
                    case "3":
                        Console.Write("How many? ");
                        string userInput = Console.ReadLine();
                        int n;
                        while(!int.TryParse(userInput, out n))
                        {
                            Console.WriteLine("Please input a valid number");
                            Console.Write("How many? ");
                            userInput = Console.ReadLine();
                        }
                        int num = Convert.ToInt32(userInput);
                        app.Deal(num);
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Random
            Random rand = new Random();

            // Create a list of Card, in which one of each card type is being created.
            List<Card> cards = new List<Card>()
            {
                new Debitcard(rand),
                new Maestro(rand),
                new VisaElectron(rand),
                new VisaDankort(rand),
                new Mastercard(rand)
            };

            // List of string, in which holds the titles of the options.
            List<string> options = new List<string>()
            {
                "Get a random card",
                "Show your options, based on your age",
                "Show all the debit cards",
                "Show all the credit cards"
            };

            // A while loop which will run indefinitely, or at least as long as the program is running
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < options.Count; i++)
                {
                    Console.WriteLine("{0}: {1}", i + 1, options[i]);
                }
                // Here is placed a try catch, in order to catch the error, if the user should enter an invalid choice for the options.
                try
                {
                    OptionsHandler(int.Parse(Console.ReadLine()), rand, cards);
                }
                catch (Exception)
                {
                    Console.WriteLine("Oh boy, that was an ugly one.. trying to put a letter as an option.. \n Well, press any key to try again...");
                    Console.ReadKey();
                }
            }
        }

        /// <summary>
        /// Optionshandler is the function which handles the input of the choice, made by the user.
        /// </summary>
        /// <param name="choice"></param>
        /// <param name="rand"></param>
        /// <param name="cards"></param>
        static void OptionsHandler(int choice, Random rand, List<Card> cards)
        {
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Card randomCard = cards[rand.Next(cards.Count)];
                    AsciFun(randomCard);
                    Console.WriteLine(randomCard.ToString());
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Indtast din alder");
                    try
                    {
                        int age = int.Parse(Console.ReadLine());
                        foreach (Card card in cards)
                        {
                            if (card.AgeLimit >= age && card.MinAge == 0)
                            {
                                AsciFun(card);
                                Console.WriteLine(card.ToString());
                            }
                            else if (card.AgeLimit == 0 && age >= card.MinAge)
                            {
                                AsciFun(card);
                                Console.WriteLine(card.ToString());
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Ups, that must have been a mistake");
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                    break;
                case 3:
                    foreach (Card card in cards)
                    {
                        if (card is IDebitCard)
                        {
                            AsciFun(card);
                            Console.WriteLine(card.ToString());
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                    break;
                case 4:
                    foreach (Card card in cards)
                    {
                        if (card is ICreditCard)
                        {
                            AsciFun(card);
                            Console.WriteLine(card.ToString());
                        }
                    }
                    Console.WriteLine();
                    Console.WriteLine("Press any key to return...");
                    Console.ReadKey();
                    break;
                default:
                    break;
            }
        }
        /// <summary>
        /// Method for creating a card simulation in the console - or at least an attempt to do so
        /// </summary>
        /// <param name="card"></param>
        static void AsciFun(Card card)
        {
            string name = "|";
            for (int i = 0; i < 44 - (card.Name.Length + 4); i++)
            {
                name += " ";
            }
            name += card.Name;
            name += "    |";

            string cardNumber = "|";
            for (int i = 0; i < 44 - (card.CardNumber.Length + 4); i++)
            {
                cardNumber += " ";
            }
            cardNumber += card.CardNumber;
            cardNumber += "    |";

            string account = "|";
            for (int i = 0; i < 44 - (card.AccountNumber.Length + 4); i++)
            {
                account += " ";
            }
            account += card.AccountNumber;
            account += "    |";

            string cardName = "|    ";
            cardName += card.CardName;
            for (int i = 0; i < 44 - card.CardName.Length - 4; i++)
            {
                cardName += " ";
            }
            cardName += "|";

            string expire = "|    ";
            expire += card.ExpireDate;
            for (int i = 0; i < 44 - card.ExpireDate.Length - 4; i++)
            {
                expire += " ";
            }
            expire += "|";

            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("|                                            |");
            Console.WriteLine(cardName);
            Console.WriteLine(name);
            Console.WriteLine("|                                            |");
            Console.WriteLine("|                            Kort nummer:    |");
            Console.WriteLine(cardNumber);
            Console.WriteLine("|    Udløbsdato:                             |");
            Console.WriteLine(expire);
            Console.WriteLine("|                           Konto nummer:    |");
            Console.WriteLine(account);
            Console.WriteLine(" --------------------------------------------");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public abstract class Card
    {
        private string name;
        /// <summary>
        /// The name of the card holder
        /// </summary>
        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }

        private string cardNumber;
        /// <summary>
        /// The card number
        /// </summary>
        public string CardNumber
        {
            get { return cardNumber; }
            protected set { cardNumber = value; }
        }

        private string expireDate;
        /// <summary>
        /// The expiration date
        /// </summary>
        public string ExpireDate
        {
            get { return expireDate; }
            protected set { expireDate = value; }
        }

        private string accountNumber;
        /// <summary>
        /// The account number
        /// </summary>
        public string AccountNumber
        {
            get { return accountNumber; }
            protected set { accountNumber = value; }
        }

        private int ageLimit;
        /// <summary>
        /// The maximum age limit to get the given type of a card
        /// </summary>
        public int AgeLimit
        {
            get { return ageLimit; }
            protected set { ageLimit = value; }
        }

        private int minAge;
        /// <summary>
        /// The minimum required age in order to recieve the given card
        /// </summary>
        public int MinAge
        {
            get { return minAge; }
            protected set { minAge = value; }
        }


        private string description;
        /// <summary>
        /// A description of the card
        /// </summary>
        public string Description
        {
            get { return description; }
            protected set { description = value; }
        }

        private string cardName;
        /// <summary>
        /// The name of the card (Mastercard, Maestro, etc...)
        /// </summary>
        public string CardName
        {
            get { return cardName; }
            protected set { cardName = value; }
        }

        /// <summary>
        /// Default constructor which sets a default name for the user
        /// </summary>
        public Card()
        {
            Name = "John Doe";
        }

        /// <summary>
        /// Constructor with possibility to set the name of the card holder
        /// </summary>
        /// <param name="name">Name of the card holder</param>
        public Card(string name) : this()
        {
            Name = name;
        } 



        /// <summary>
        /// Generates the account number for the card, randomly using Random
        /// </summary>
        /// <param name="rand">an instance of the class Random</param>
        protected void GenerateAccountNumber(Random rand)
        {
            string account = "3520";
            for (int i = 0; i < 10; i++)
            {
                account += rand.Next(10).ToString();
            }
            AccountNumber = account;
        }
        /// <summary>
        /// Generates the card number, based on the given prefix and the required length
        /// </summary>
        /// <param name="length">The decired length of the card number</param>
        /// <param name="prefix">The prefixes of the card number</param>
        /// <param name="rand">an instance of the class Random</param>
        protected void GenerateCardNumber(int length, string prefix, Random rand)
        {
            string card = prefix;
            for (int i = 0; i < length - prefix.Length; i++)
            {
                card += rand.Next(10).ToString();
            }
            CardNumber = card;
        }
        /// <summary>
        /// Generates the expiration date of the card
        /// </summary>
        /// <param name="years">How many years untill the card should expire</param>
        /// <param name="months">How many months untill the card should expire</param>
        /// <param name="days">How many days untill the card should expire</param>
        protected void GenerateExpireDate(int years, int months, int days)
        {
            ExpireDate = DateTime.Now.AddYears(years).AddMonths(months).AddDays(days).ToLongDateString();
        }



    }
}

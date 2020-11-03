using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Mastercard : Card, ICreditCard
    {
        public Mastercard(Random rand)
        {
            //Created a list of the possible prefixes for the card number.
            List<int> prefixes = new List<int>() { 51, 52, 53, 54, 55 };

            //Generate the card number, with the given length (16) and a random prefix from the prefixes list, 
            //and last an instance of the class Random
            GenerateCardNumber(16, prefixes[rand.Next(prefixes.Count)].ToString(), rand);

            //Generate the account number, only providing an instance of class Random - since the accounts is being created by a 
            //bank standard, and not card specific.
            GenerateAccountNumber(rand);

            //Generate the expiration date, 5 years from today.
            GenerateExpireDate(5, 0, 0);

            //Provide the card name
            CardName = "Mastercard";

            //Provide the description
            Description = "Mastercard er et kreditkort, som tilbyder en kredit på op til 40.000 kr. om\nmåneden.Saldoen opgøres en gang om måneden og kunden betaler sit\nudestående.Man kan hæve op til 5000 kr.om dagen på dette kort og op til\n30.000 om måneden";
        }

        /// <summary>
        /// Overrides the ToString() method, in order to easily get and overview of the object, and in this  
        /// case, I'm return the Description
        /// </summary>
        /// <returns>Description</returns>
        public override string ToString()
        {
            return Description;
        }

        public void CalculateBalance()
        {
            //Implement this method in order to calculate the balance on a monthly basis, as this is how this credit card work
        }

    }
}

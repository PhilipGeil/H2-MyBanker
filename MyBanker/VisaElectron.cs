using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaElectron : Card, IDebitCard
    {
        public VisaElectron(Random rand)
        {
            //Created a list of the possible prefixes for the card number.
            List<int> prefixes = new List<int>() { 4026, 417500, 4508, 4844, 4913, 4917 };

            //Generate the card number, with the given length (16) and a random prefix from the prefixes list, 
            //and last an instance of the class Random
            GenerateCardNumber(16, prefixes[rand.Next(prefixes.Count)].ToString(), rand);

            //Generate the account number, only providing an instance of class Random - since the accounts is being created by a 
            //bank standard, and not card specific.
            GenerateAccountNumber(rand);

            //Generate the expiration date, 5 years from today.
            GenerateExpireDate(5, 0, 0);

            //Provide the minimum age, which in this case is 15
            MinAge = 15;

            //Provide the card name
            CardName = "Visa Electron";

            //Provide the description
            Description = "Visa Electron er et debetkort, men dette kan bruges internationalt og på Nettet.\nKortet udstedes til kunder over 15 år.Der kan max.Bruges 10000 kr om\nmåneden på dette kort.";
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

        public void WithdrawMoneyNow()
        {
            //Implement this method in order to withdraw money immediately, as that is how debitcards work.
        }

    }
}

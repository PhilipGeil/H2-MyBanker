using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Debitcard : Card, IDebitCard
    {
        public Debitcard(Random rand)
        {
            //Generate the card number, as the card is created, with the given parameters for this card.
            GenerateCardNumber(16, "2400", rand);

            //Generate the account number, only providing an instance of class Random - since the accounts is being created by a 
            //bank standard, and not card specific.
            GenerateAccountNumber(rand);

            //Provide the age limit, as this card is primarily given to those under 18
            AgeLimit = 18;

            //Provide the card name
            CardName = "Hævekort";

            //As this card doesn't expire, it is just set to "Aldrig"
            ExpireDate = "Aldrig";

            //Provide the description
            Description = "Dette kort tilbydes primært til kunder under 18 år og til kunder som ikke \nopfylder kriterierne for VISA, Maestro eller Mastercard.Kortet er et debetkort,\nhvilket betyder at pengene trækkes med det samme fra kontoen og der kan ikke\nlaves et overtræk.";
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

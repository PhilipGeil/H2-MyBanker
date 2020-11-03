using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class Maestro : Card, IDebitCard
    {
        public Maestro(Random rand)
        {
            //Created a list of the possible prefixes for the card number.
            List<int> prefixes = new List<int>() { 5018, 5020, 5038, 5893, 6304, 6759, 6761, 6762, 6763 };

            //Generate the card number, with the given length (19) and a random prefix from the prefixes list, 
            //and last an instance of the class Random
            GenerateCardNumber(19, prefixes[rand.Next(prefixes.Count)].ToString(), rand);

            //Generate the account number, only providing an instance of class Random - since the accounts is being created by a 
            //bank standard, and not card specific.
            GenerateAccountNumber(rand);

            //Generate the expiration date, 5 years and 8 months from today.
            GenerateExpireDate(5, 8, 0);

            //Provide the minimum age, which in this case is 18
            MinAge = 18;

            //Provide the card name
            CardName = "Maestro";

            //Provide the description
            Description = "Maestrokortet er også et debetkort, men dette kan bruges internationalt og på\nNettet.Man skal være 18 førend dette kort kan udstedes til kunden";
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

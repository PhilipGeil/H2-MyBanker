using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    public class VisaDankort : Card, ICreditCard, IDebitCard
    {

        public VisaDankort(Random rand)
        {
            //Generate the card number, as the card is created, with the given parameters for this card.
            GenerateCardNumber(16, "4", rand);

            //Generate the account number, only providing an instance of class Random - since the accounts is being created by a 
            //bank standard, and not card specific.
            GenerateAccountNumber(rand);

            //Generate the expiration date, 5 years from today.
            GenerateExpireDate(5, 0, 0);

            //Provide the minimum age, which in this case is 18
            MinAge = 18;

            //Provide the card name
            CardName = "Visa/Dankort";

            //Provide the description
            Description = "Dette er et delvist kreditkort med en grænse på 20.000 kr. Man skal være 18,\nførend dette kort kan udstedes. Dette kort kan gå i overtræk og man kan hæve\nop til 25.000 kr.på dette kort om måneden";
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
            //Does nothing - assuming this would be both IDebitCard and ICreditCard, because the assignment stated that it is only 
            //a part credit card, and therefore I'm assuming. 
        }

        public void CalculateBalance()
        {
            //This would be the method to use, since this card provides the opportunity for withdrawing more than what is 
            //available on the account, there would need to be some sort of balancing on it, instead of withdrawing it right away.
        }
    }
}

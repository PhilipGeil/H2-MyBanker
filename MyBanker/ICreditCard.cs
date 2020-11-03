using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface ICreditCard
    {
        /// <summary>
        /// Method for calculating the balance, since credit cards are balanced monthly.
        /// </summary>
        void CalculateBalance();
    }
}

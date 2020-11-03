using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBanker
{
    interface IDebitCard
    {
        /// <summary>
        /// Method for withdrawing the money immediately.
        /// </summary>
        void WithdrawMoneyNow();
    }
}

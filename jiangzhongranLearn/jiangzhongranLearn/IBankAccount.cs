using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiangzhongranLearn
{
    public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool Withdraw(decimal amount);
        decimal Balance
        {
            get;
        }
    }
}

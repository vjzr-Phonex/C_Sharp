﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace jiangzhongranLearn
{
    public class SaverAccount : IBankAccount
    {
        private decimal balance;
        public void PayIn(decimal amount)
        {
            balance += amount; 
        }

        public bool Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                return true;
            }
            Console.WriteLine("Withdraw atempt failed.");
            return false;
        }

        public decimal Balance
        {
            get 
            {
                return balance;
            }
        }

        public override string ToString()
        {
            return String.Format("Venus Bank Sacer: Balance = {0,6:c}",balance);
        }
    }

}

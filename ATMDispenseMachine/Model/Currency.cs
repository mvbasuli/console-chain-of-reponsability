using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ATMDispenseMachine.Model
{
    public class Currency
    {
        private int amount;

        public Currency(int amt)
        {
            this.amount = amt;
        }

        public int getAmount()
        {
            return this.amount;
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class Current : Accounts
    {
        public Current(double balance, double Interest, string name, int Overdraft, int accNumber)
            : base(balance, Interest, name, accNumber)
        {
            if (Overdraft > 0)
            {
                this.Overdraft = true;
                OverdraftLimit = Overdraft;
            }
        }

        public override bool Withdraw(double x)
        {
            if (x > (Balance + OverdraftLimit))
            {
                return false;
            }
            else
            {
                Balance -= x;
                return true;
            }
        }
    }
}

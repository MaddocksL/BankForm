using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankForm
{
    class Accounts
    {
        public string Name;
        protected double Balance;
        double InterestValue;
        protected int AccountNumber;
        public bool Overdraft = false;
        public int OverdraftLimit = 0;

        public Accounts(double balance, double Interest, string name, int accountNumber)  //constructor
        {
            Balance = balance;
            InterestValue = Interest;
            Name = name;
            AccountNumber = accountNumber;
        }

        public virtual bool Withdraw(double x)
        {
            //Removes Input from balance
            if (x > Balance)
            {
                return false;
            }
            else
            {
                Balance -= x;
                return true;
            }
        }

        public bool Deposit(double x)
        {
            //Adds Input to balance
            Balance += x;
            return true;
        }

        public double ShowBalance()
        {
            return Balance;
        }

        public void ApplyInterest()
        {
            if (Balance > 0){
                //Take Interest Value as number and creates multiplier for Balance 5% = 1.05
                Balance = Balance * (1 + (InterestValue / 100));
            }
            
        }
    }
}

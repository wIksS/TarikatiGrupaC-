using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Account
    {
        public Account(Owner owner, int balance)
        {
            this.Balance = balance;
            this.Owner = owner;
        }

        public decimal Balance{ get; set; }

        public Owner Owner { get; set; }

        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
            if (this.Balance < 0)
            {
                throw new ArgumentException("Nema kesh!");
            }
        }
    }
}

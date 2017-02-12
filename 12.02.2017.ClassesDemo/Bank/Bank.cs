using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class Bank
    {
        public Bank()
        {
            this.Accounts = new List<Account>();
        }

        public List<Account> Accounts { get; set; }

        public override string ToString()
        {
            string result = "";
            for (int i = 0; i < this.Accounts.Count; i++)
            {
                result += this.Accounts[i].Owner + " Balance: " 
                    + Accounts[i].Balance + "\n";
            }

            return result;
        }
    }
}

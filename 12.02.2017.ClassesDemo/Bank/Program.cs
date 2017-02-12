using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of accounts:");
            int numberOfAccounts = int.Parse(Console.ReadLine());
            Bank reiffeisen = new Bank();

            for (int i = 0; i < numberOfAccounts; i++)
            {
                Console.WriteLine("Enter account balance: ");
                int balance = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter age: ");
                int age = int.Parse(Console.ReadLine());

                Owner owner = new Owner(name, age);
                Account account = new Account(owner,balance);
                reiffeisen.Accounts.Add(account);
            }

            Console.WriteLine(reiffeisen);            
        }
    }
}

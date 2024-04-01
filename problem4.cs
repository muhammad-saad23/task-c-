using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    public class BankAccount
    {
        private int balance;
        private int accountNumber;

        public void set(int balance,int accountNumber)
        {
            this.balance = balance;
            this.accountNumber= accountNumber;
        }

        public void deposit(int amount)
        {
            Console.WriteLine($"balance:{ balance}");
            if (amount > 0)
            {
                balance += amount;

            Console.WriteLine($"deposit: {amount}  balance: {balance}");
            }
            else
            {
                Console.WriteLine("deposit amount");
            }

        }


        public void withdraw(int amount) 
        {
            if (amount > 0)
            {
            balance -= amount;
                Console.WriteLine($"withdraw:{amount} new balance:{balance}");
            }
            else
            {
                Console.WriteLine("no balance");
            }
        }

        
    }

    internal class problem4
    {
    //    static void Main(string[] args)
    //    {
    //        BankAccount account = new BankAccount();
    //        account.set(1000, 10105);
    //        account.deposit(500);
    //        account.withdraw(200);

    //}

    }
}

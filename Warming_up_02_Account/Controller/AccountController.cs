using BankAccountExercise.Models;
using System;


namespace BankAccountExercise.Controller
{
    public class AccountController
    {

        public void AddMoney(Account account, double amount)
        {
            if (amount != null && amount >= 0)
            {
                var OldBalance = account.Balance;
                account.Balance += amount;
                ShowTransition(OldBalance, account);
            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }

        }

        public void WithdrawMoney(Account account, double amount)
        {
            if (amount != null && amount > 0)
            {
                var OldBalance = account.Balance;
                var newBalance = account.Balance - amount;
                account.Balance = newBalance > 0 ? newBalance : OldBalance;
                ShowTransition(OldBalance, account);
            }
            else
            {
                Console.WriteLine("Invalid Amount!");
            }

        }

        public void TransferMoney(Account account1,Account account2, double amount)
        {
            Console.WriteLine($"\n\tAccount1 balance was {account1.Balance} and Account2 balance was {account2.Balance}  ");
            account1.Balance -= amount;
            account2.Balance += amount;
            Console.WriteLine($"\tAccount {account1.AccountHolder} has transfer {amount} to Account {account2.AccountHolder} ");
            Console.WriteLine($"\tAccount {account1.AccountHolder} balance becomes {account1.Balance} and Account {account2.AccountHolder} becomes {account2.Balance}");
        }
        private void ShowTransition(double oldBalance, Account account)
        {
            Console.WriteLine($"\n\tOld Balance {oldBalance}," +
                $" Current Balance {account.Balance}, Added/Subtract Amount {account.Balance - oldBalance}\n ");
        }
    }
}

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
        private void ShowTransition(double oldBalance, Account account)
        {
            Console.WriteLine($"\n\tOld Balance {oldBalance}," +
                $" Current Balance {account.Balance}, Added/Subtract Amount {account.Balance - oldBalance}\n ");
        }
    }
}

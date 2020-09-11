using BankAccountExercise.Controller;
using BankAccountExercise.Models;


namespace BankAccountExercise
{
    public class Program
    {
       

        static void Main(string[] args)
        {
            AccountController accountController = new AccountController();

            Account AccountOne = new Account("Nesreen Al-shargabi", 2000, "ING", "NL20INGB0001234567");
            Account AccountTwo = new Account("Yusuf Al-Komem", 5000, "ING", "NL20INGB0001234587");
            Account AccountThree = new Account("Sara Al-Komem", 10000, "ING", "NL20INGB0001234597");

            /*
             * added money to the accounts
             * Add 1,000 to account 1
             * Add 1,500 to account 1
             * Add 5,500 to account 3
             */
            accountController.AddMoney(AccountOne,1500);
            accountController.AddMoney(AccountOne, 1000);
            accountController.AddMoney(AccountThree, 5500);


            /*
             * Withdraw Money from accounts
             * Remove 3,000 from account 2
             * Remove 15,000 from account 3 (should have -5,000 then)
             * Remove 100 from account 1
             * Remove 142,- from account 2
             */
            accountController.WithdrawMoney(AccountTwo, 3000);
            accountController.WithdrawMoney(AccountThree, 15000);
            accountController.WithdrawMoney(AccountOne, 100);
            accountController.WithdrawMoney(AccountTwo, 142);



        }
    }
}

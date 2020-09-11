

namespace BankAccountExercise.Models
{
   public class Account
    {
      
      /*
       the properties with setter and getter
       */
       
        public string AccountHolder {  get;  set; }
        public double Balance { get;  set; }

        public string BankName { get;  set; }

        public string IBAN { get;  set; }


        /* 
         constructor with all the properties
         */
        public Account(string accountHolder, double balance, string bankName, string iBAN)
        {
            AccountHolder = accountHolder;
            Balance = balance;
            BankName = bankName;
            IBAN = iBAN;
        }


        public override string ToString()
        {
            return "\t Account Holder "+AccountHolder+" Balance "+Balance+" Bank Name "+ BankName+" IBAN  "+ IBAN;
        }
    }
}

using System;
using Week1_Assignments.UserInterface;
namespace Week1_Assignments
{
    class Account
    {
        public int AccountNo { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; private set; } = 10000;
        public void Credit(double amount) => Balance += amount;

        public void Debit(double amount)
        {
            if (Balance < amount)
            {
                throw new Exception("Insufficient funds!!!");
            }
            Balance -= amount;
        }
        public virtual void CalculateInterest()
        {
            double principle = Balance;
            double rate = 0.065;
            double term = 0.5;// Half yearly
            var interest = principle * rate * term;
            Credit(interest);
        }
    }
    class SDAccount : Account
    {
        public override void CalculateInterest()
        {    
            double principle = Balance;
            double rate = 0.065;
            double term = 0.5;// Half yearly
            var interest = principle * rate * term;
            Credit(interest);
        }   
    }
    class FDAccount : Account
    {
        public override void CalculateInterest()
        {
            base.CalculateInterest();
            Credit(234);
        }
    }

    class RDAccount : Account
    {
        public override void CalculateInterest()
        {
            double principle = Balance;
            int time = Util.GetNumber("Enter the number of months");
            int rate = Util.GetNumber("Enter the rate of interest");
            var interest = principle * time * (time + 1) * rate / 2400;
            Credit(interest);
        }
    }

    static class AccountFactory
    {
        public static Account CreateAccount(string accType)
        {
            if (accType.ToLower() == "sd")
                return new SDAccount();
            else if (accType.ToLower() == "fd")
                return new FDAccount();
            else if (accType.ToLower() == "rd")
                return new RDAccount();
            else
                return null;

        }
    }
    class Assignment12
    {
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("Enter the type of account as: \n\n 1. For SD Account----Type sd \n 2. For FD Account----Type fd \n 3. For RD Account----Type rd \n");
                Account acc = AccountFactory.CreateAccount(Console.ReadLine());
                acc.AccountNo = 1234567890;
                acc.HolderName = "Vinod Kumar";
                Console.WriteLine($"Account Number: {acc.AccountNo} \nAccount Holder name: {acc.HolderName}");
                acc.CalculateInterest();
                Console.WriteLine("The Current Balance : " + acc.Balance);
                Console.WriteLine("---------------------------------------");
            } while (true);
        }
    }
}

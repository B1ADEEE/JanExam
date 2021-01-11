using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JanExam
{
    public abstract class Accounts : IComparable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Balance { get; set; }
        public string InterestDate { get; set; }
        public Accounts(string firstname, string lastname, double balance, string interestdate)
        {
            FirstName = firstname;
            LastName = lastname;
            Balance = balance;
            InterestDate = interestdate;
        }
        public abstract double CalculateInterest();
        public override string ToString()
        {
            return $"{LastName.ToUpper()}, {FirstName}";
        }

    }
    public class CurrentAccount : Accounts
    {
        public CurrentAccount(string firstname, string lastname, double balance, string interestdate) : base(firstname, lastname, balance, interestdate)
        {

        }
        //Implementation of abstract method
        public override double CalculateInterest()
        {
            return Balance * 0.03;
        }
    }

    public class SavingAccount : Accounts
    {
        public SavingAccount(string firstname, string lastname, double balance, string interestdate):base(firstname,lastname,balance,interestdate)
        {
            
        }
        //Implementation of abstract method
        public override double CalculateInterest()
        {
            return Balance * 0.06;
        }
    }
}

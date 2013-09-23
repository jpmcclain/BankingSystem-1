using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Customer
    {
        public string customerName { get; set; }
        public string customerUsername { get; set; }
        public string customerPassword { get; set; }
        public string emailAddress { get; set; }
        public Address address { get; set; }
        public object checkingAccount { get; set; }
        public object savingsAccount { get; set; }

        public Customer(string name, string user, string password, string email, int num, int num2, bool state, double funds, double funds2)
        {
            customerName = name;
            customerUsername = user;
            customerPassword = password;
            emailAddress = email;
            checkingAccount = new AccountInfo(num, state, funds);
            savingsAccount = new AccountInfo(num2, state, funds2);
        }
    }

    public class AccountInfo
    {
        public int accountNumber { get; set; }
        public bool isAccountLocked { get; set; }
        public double accountBalance { get; set; }

        public AccountInfo(int num, bool state, double funds)
        {
            accountNumber = num;
            isAccountLocked = state;
            accountBalance = funds;
        }
    }

    public class Address
    {
        public string street { get; set; }
        public string state { get; set; }
        public string city { get; set; }
        public int zipCode { get; set; }
    }
}

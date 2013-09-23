using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem.Common
{
    public static class GlobalList
    {
        public static Customer _customer1 { get; set; }
        public static Customer _customer2 { get; set; }

        public GlobalList()
        {
            _customer1 = new Customer("Sam", "moreMoney", "12345", "whatever@ttu.edu", 436764, 792304, false, 2367.47, 1155.82);
            _customer2 = new Customer("Bill", "lessMoney", "54321", "anyways@ttu.edu", 783496, 425395, false, 0.47, 268.82);
        }
    }
}

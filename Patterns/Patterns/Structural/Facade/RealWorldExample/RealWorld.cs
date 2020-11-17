using System;
using System.Collections.Generic;
using System.Text;

namespace Patterns.Structural.Facade.RealWorldExample
{
    public class RealWorld
    {
        //static void Main()
        //{
        //    var mortage = new Mortage();
        //    var customer = new Customer("Mao Hernandez");

        //    bool elegible = mortage.IsElegible(customer, 125000);

        //    Console.WriteLine($"\n {customer.Name} has been {(elegible ? "Approved" : "Rejected")}");
        //    Console.ReadKey();
        //}

        class Bank
        {
            public bool HasSufficientSavings(Customer customer, int amount)
            {
                Console.WriteLine($"Check bank for {customer.Name}");
                return true;
            }
        }

        class Credit
        {
            public bool HasGodCredit(Customer customer)
            {
                Console.WriteLine($"Check credit for {customer.Name}");
                return true;
            }
        }

        class Loan
        {
            public bool HasNoBadLoans(Customer customer)
            {
                Console.WriteLine($"Check loans for {customer.Name}");
                return true;
            }
        }

        class Mortage
        {
            Bank _bank = new Bank();
            Loan _loan = new Loan();
            Credit _credit = new Credit();

            public bool IsElegible(Customer customer, int amount)
            {
                Console.WriteLine($"{customer.Name} applies for {string.Format("C", amount)}");

                bool elegible = _bank.HasSufficientSavings(customer, amount) && _loan.HasNoBadLoans(customer) &&
                               _credit.HasGodCredit(customer);

                return elegible;
            }
        }

        class Customer
        {
            private string _name;
            public Customer(string name)
            {
                this._name = name;
            }

            public string Name
            {
                get => _name;
            }
        }
    }
}

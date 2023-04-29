using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oops_Concept_Examples
{
    /*
    Encapsulation is a fundamental concept in object-oriented programming (OOP) that refers to the bundling of data and the methods that operate on that data within a single unit.
    In C#, this is typically achieved through the use of classes.

    The idea behind encapsulation is to keep the implementation details of a class hidden from the outside world,
    and to only expose a public interface that allows users to interact with the class in a controlled and safe manner.
   
    */



    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            balance += amount;
        }

        public void Withdraw(double amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public double GetBalance() { return balance; }
    }

}

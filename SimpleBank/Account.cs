using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    public abstract class Account
    {
        private Person _owner;
        private double _balance;
        public double Blanace { get { return _balance; } }

        public string Owner { get { return _owner.ToString(); } }

        public Account(Person owner)
        {
            _owner = owner;
            _balance = 0;
        }
        public virtual bool Withdraw(double amount)
        {
            return false;
        }

        public virtual bool Deposite(double amount)
        {
            _balance += amount;
            return true;
        }

    }

}

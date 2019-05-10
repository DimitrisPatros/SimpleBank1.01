using System;
using System.Collections.Generic;
using System.Text;

namespace SimpleBank
{
    public class SimpleAccont : Account
    {
        public SimpleAccont(Person owner) : base(owner){}

        public override bool Deposite(double amount)
        {
            return base.Deposite(amount);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public override bool Withdraw(double amount)
        {
            return base.Withdraw(amount);
        }
    }
}

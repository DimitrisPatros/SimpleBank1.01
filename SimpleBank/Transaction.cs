using System;

namespace SimpleBank
{
    public class Transaction
    {
        private DateTime DateTime{ get; set; }
        public double Amount { get; set; }
        public string Action { get; set; }
        public string Actor { get; set; }
        public DateTime dateTime { get; set; }


        public Transaction() { }
        public Transaction(DateTime dateTime)
        {
            this.dateTime = dateTime;
        }

        public Transaction(DateTime dateTime, double amount, string action, string actor)
        {
            DateTime = dateTime;
            Amount = amount;
            Action = action;
            Actor = actor;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            return $"{DateTime} {Amount} {Action} {Actor}";
        }
    }
}

using System;

namespace SimpleBank
{
    class Program
    {
        static void Main(string[] args)
        {

            var person = new Person(1, "Dimitris", "Athens");
            var account = new AnaliticAccount(person);
            account.LoadToJason();
            //Console.WriteLine(account);
            //account.PrintTransactions();
            account.Deposite(55);
            account.Deposite(35);
            account.Deposite(45);
            account.Deposite(1140);
            account.Withdraw(-200);

            //account.PrintTransactions();
            //account.SaveToFile("fristTryToSave.txt");
            //this action save to the list
            account.SaveToJason();
        }
    }
}

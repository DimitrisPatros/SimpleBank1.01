using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Newtonsoft.Json;

namespace SimpleBank
{
    public class AnaliticAccount : Account
    {
        private const string _fileName = @"C:\Users\patro\Desktop\projects\tasks\tryToSaveToJason.json";
        private readonly List<Transaction> _transactions;
        

        public AnaliticAccount(Person owner) : base(owner)
        {
            _transactions = new List<Transaction>();
        }

        public override bool Deposite(double amount)
        {
            _transactions.Add(new Transaction(DateTime.Now,
                               amount, "deposit", Owner));

            return base.Deposite(amount);
        }

        public override bool Withdraw(double amount)
        {
            _transactions.Add(new Transaction(DateTime.Now,
                              amount, "Withdraw", Owner));

            return base.Withdraw(amount);
        }

        public void PrintTransactions()
        {
            foreach (Transaction t in _transactions)
            {
                Console.WriteLine(t);
            }
        }
        // This is for saving files in a txt format from a list
        public void SaveToFile(string filename)
        {
           using (StreamWriter file = new StreamWriter($"C:\\Users\\patro\\Desktop\\projects\\tasks\\{filename}.txt"))
           {
               foreach (Transaction t in _transactions)
               {
                   file.WriteLine(t);
               }
           }
        }
        //This method is for saving files in json format
        public void SaveToJason()
        {
            string json = JsonConvert.SerializeObject(_transactions.ToArray());

            //write string to file
            System.IO.File.WriteAllText(_fileName, json);

        }

        //load from json file type
        public void LoadToJason()
        {

            string data = File.ReadAllText(_fileName);
            var tempTransactions = JsonConvert.DeserializeObject<List<Transaction>>(data);
            foreach (Transaction t in tempTransactions)
            {
               
                _transactions.Add(t);
            }
            //_transactions.Sort();


        }


        public override string ToString()
        {
            return base.ToString();
        }
    }
}

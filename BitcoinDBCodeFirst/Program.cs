using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace BitcoinDBCodeFirst
{
    class Program
    {
        static void ParseJson(string filename)
        {
            //TODO build structures based on the json
        }
        
        static void StoreData()
        {
            //TODO Add to Database Transactions and Deposits
        }

        static void RetrieveDeposits()
        {
            //TODO Output at console deposits
        }

        static void Main(string[] args)
        {
            ParseJson("transaction.json");

            StoreData();

            RetrieveDeposits();
        }
    }
}

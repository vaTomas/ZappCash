using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using ZappCash.packages;
using ZappCash.packages.json;

namespace ZappCash
{
    internal class AccountsControl
    {
        //variables
        protected string FileLocation { get; set; }
        protected List<Account> Accounts { get; set; }
        public Account SelectedAccount { get; set; }
        protected int SelectedAccountIndex { get; set; }
        public Transaction SelectedTransaction { get; set; }
        protected int SelectedTransactionID { get; set; }
        
        //initialize
        public AccountsControl()
        {

        }
        public AccountsControl(string filePath)
        {
            FileLocation = filePath;
            Read();
        }


        //methods
        public void Read()
        {
            GetAccounts();
        }

        public List<Account> GetAccounts()
        {
            jsonFile myFile = new jsonFile(FileLocation);

            Accounts = JsonConvert.DeserializeObject<List<Account>>(myFile.jsonContent);
            return Accounts;
        }


        public Account GetAccount(string AccountID)
        {
            SelectedAccountIndex = Accounts.FindIndex(x => x.Id.Equals(AccountID));
            SelectedAccount = Accounts[SelectedAccountIndex];
            return SelectedAccount;
        }

        public Transaction GetTransaction(string TransactionID)
        {
            SelectedTransactionID = SelectedAccount.Transactions.FindIndex(x => x.Id.Equals(TransactionID));
            SelectedTransaction = Accounts[SelectedAccountIndex].Transactions[SelectedTransactionID];
            return SelectedTransaction;
        }

        public Transaction GetTransaction(string TransactionID, string AccountID)
        {
            GetAccount(AccountID);
            return GetTransaction(TransactionID);
        }

        public void NewTransaction()
        {
            Transaction newTransaction = new Transaction("");
            SelectedAccount.Transactions.Add(newTransaction);
        }

        protected void Overwrite()
        {
            //Accounts.FindIndex;

            Accounts[1].Transactions.Clear();
        }
    }
}

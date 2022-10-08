using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

using ZappCash.packages;
using ZappCash.classes;
using ZappCash.database;

namespace ZappCash
{
    internal class AccountsManager
    {        
        //initialize
        public AccountsManager()
        {

        }


        //methods

        public static Account GetAccount(string AccountId)
        {
            List <Account> accounts = db_ZappCash.Accounts; //import from database
            
            int accountIndex = GetAccountIndex(accountId: AccountId);
            Account account = accounts[accountIndex];

            return account;
        }

        private static int GetAccountIndex(string accountId)
        {
            List<Account> accounts = db_ZappCash.Accounts;
            return accounts.FindIndex(x => x.Id.Equals(accountId));
        }

        public static Transaction GetTransaction(string AccountId,string TransactionId)
        {
            List<Account> accounts = db_ZappCash.Accounts; //import from database
            
            int accountIndex = GetAccountIndex(accountId: AccountId);
            int transactionIndex = getTransactionIndex(accountId: AccountId, transactionId: TransactionId);

            Transaction transaction = accounts[accountIndex].Transactions[transactionIndex];

            return transaction;
        }

        private static int getTransactionIndex(string accountId, string transactionId)
        {
            List<Account> accounts = db_ZappCash.Accounts; //import from database
            int accountIndex = GetAccountIndex(accountId: accountId);

            Account account = accounts[accountIndex];

            int transactionIndex = account.Transactions.FindIndex(x => x.Id.Equals(transactionId));

            return transactionIndex;
        }


        public static void NewTransaction(string AccountID, string TransferAccountId, DateTime Date, string Number = "", string Description = "", long Amount = 0, long Balance = 0)
        {
            List<Account> accounts = db_ZappCash.Accounts; //import from database


            string transactionId = IdGenerator.GenerateID(AccountID);

            Transaction primaryTransaction = new Transaction(transactionId, Date, Number, Description, TransferAccountId, Amount, Balance = 0);
            Transaction mirrorTransaction = new Transaction(transactionId, Date, Number, Description, AccountID, -Amount, Balance = 0);

            int primaryAccountIndex = GetAccountIndex(AccountID);
            int mirrorAccountIndex = GetAccountIndex(TransferAccountId);

            accounts[primaryAccountIndex].Transactions.Add(primaryTransaction);
            accounts[mirrorAccountIndex].Transactions.Add(mirrorTransaction);

            db_ZappCash.Accounts = accounts; //export to database

        }

        public static void NewAccount(string ParentId = "0000000000000000", byte Decimals = 2, string Name = "", string Code = "", string Description = "", string Color = "#ffffff", string Notes = "", string AssetType = "PHP", bool IsPlaceholder = false)
        {
            List<Account> accounts = db_ZappCash.Accounts; //import from database
            AccountAttributes accountAttributes = new AccountAttributes(name: Name, code: Code, description: Description, color: Color, notes: Notes);

            string accountId = IdGenerator.GenerateID(ParentId);

            Account account = new Account(id: accountId, attributes: accountAttributes, assetType: AssetType, isPlaceholder: IsPlaceholder, parentId: ParentId, decimals: Decimals);

            accounts.Add(account);

            db_ZappCash.Accounts = accounts; //export to database
        }


    }
}

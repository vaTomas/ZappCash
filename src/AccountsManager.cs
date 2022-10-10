using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ZappCash.packages;
using ZappCash.classes;
using ZappCash.database;

namespace ZappCash
{
    internal class AccountsManager
    {        
        //Database
        public static List<Account> GetAccounts()
        {
            return db_ZappCash.Accounts;
        }
        private static void setAccounts(List<Account> accounts)
        {
            db_ZappCash.Accounts = accounts;
        }
        
        public static void New()
        {
            db_ZappCash.CheckIntegrity();

            

        }

        //General Actions
        public static void UpdateBalances()
        {
            List<Account> accounts = GetAccounts();

            foreach (Account account in accounts)
            {
                long accountBalance = 0;
                foreach (Transaction transaction in account.Transactions)
                {
                    accountBalance += transaction.Amount;
                    transaction.Balance = accountBalance;
                }
                account.Balance = accountBalance;
            }

            setAccounts(accounts);
        }


        //Accounts
        public static Account GetAccount(string AccountId)
        {
            UpdateBalances();
            List <Account> accounts = GetAccounts(); //import from database
            
            int accountIndex = GetAccountIndex(accountId: AccountId);
            Account account = accounts[accountIndex];

            return account;
        }
        private static int GetAccountIndex(string accountId)
        {
            List<Account> accounts = GetAccounts();
            return accounts.FindIndex(x => x.Id.Equals(accountId));
        }
        public static void NewAccount(string ParentId = "0000000000000000", byte Decimals = 2, string Name = "", string Code = "", string Description = "", string Color = "#ffffff", string Notes = "", string AssetType = "PHP", bool IsPlaceholder = false)
        {
            AccountAttributes accountAttributes = new AccountAttributes(name: Name, code: Code, description: Description, color: Color, notes: Notes);

            string accountId = IdGenerator.GenerateID(ParentId);

            Account account = new Account(id: accountId, attributes: accountAttributes, assetType: AssetType, isPlaceholder: IsPlaceholder, parentId: ParentId, decimals: Decimals);

            NewAccount(account);
        }
        private static void NewAccount(Account Account)
        {
            List<Account> accounts = GetAccounts();
            accounts.Add(Account);
            setAccounts(accounts);
            UpdateBalances();
        }
        public static void DeleteAccount(string AccountId, bool DeleteTransactions = true)
        {
            if (!DeleteTransactions)
            {
                List<Account> accounts1 = GetAccounts();
                int accountIndex1 = GetAccountIndex(AccountId);
                accounts1.RemoveAt(accountIndex1);
                setAccounts(accounts1);
                return;
            }

            List<string> accountTransactionIds = new List<string>();

            {
                Account account = GetAccount(AccountId);

                foreach (Transaction transaction in account.Transactions)
                {
                    accountTransactionIds.Add(transaction.Id);
                }
            }

            int accountIndex = GetAccountIndex(AccountId);

            List<Account> accounts = db_ZappCash.Accounts; //import from database
            accounts.RemoveAt(accountIndex);

            foreach (string transactionId in accountTransactionIds)
            {
                DeleteTransaction(transactionId);
            }

            db_ZappCash.Accounts = accounts;
            UpdateBalances();
        }
        public static void EditAccount(string AccountId, string Name = null, string Code = null, string Description = null, string Color = null, string Notes = null, bool? IsPlaceholder = null, string ParentId = null, byte? Decimals = null)
        {
            Account account = GetAccount(AccountId);
            int accountIndex = GetAccountIndex(AccountId);

            if (Name != null) { account.Attributes.Name = Name; }
            if (Code != null) { account.Attributes.Code = Code; }
            if (Description != null) { account.Attributes.Description = Description; }
            if (Color != null) { account.Attributes.Color = Color; }
            if (Notes != null) { account.Attributes.Notes = Notes; }
            if (IsPlaceholder != null) { account.IsPlaceholder = (bool)IsPlaceholder; }
            if (ParentId != null) { account.ParentId = ParentId; }
            if (Decimals != null) { account.Decimals = (byte)Decimals; }

            DeleteAccount(AccountId, false);
            NewAccount(account);
            UpdateBalances();
        }
        
        //Transactions
        public static Transaction GetTransaction(string AccountId,string TransactionId)
        {
            UpdateBalances();
            List<Account> accounts = GetAccounts(); //import from database
            
            int accountIndex = GetAccountIndex(accountId: AccountId);
            int transactionIndex = getTransactionIndex(accountId: AccountId, transactionId: TransactionId);

            Transaction transaction = accounts[accountIndex].Transactions[transactionIndex];

            return transaction;
        }
        private static int getTransactionIndex(string accountId, string transactionId)
        {
            List<Account> accounts = GetAccounts(); //import from database
            int accountIndex = GetAccountIndex(accountId: accountId);

            Account account = accounts[accountIndex];

            int transactionIndex = account.Transactions.FindIndex(x => x.Id.Equals(transactionId));

            return transactionIndex;
        }
        private static void NewTransaction(string AccountID, Transaction Transaction)
        {
            List<Account> accounts = GetAccounts(); //import from database

            Transaction mirrorTransaction = Transaction;
            mirrorTransaction.TransferId = AccountID;
            mirrorTransaction.Amount = -Transaction.Amount;

            int primaryAccountIndex = GetAccountIndex(AccountID); 
            int mirrorAccountIndex = GetAccountIndex(Transaction.TransferId);

            accounts[primaryAccountIndex].Transactions.Add(mirrorTransaction);
            accounts[mirrorAccountIndex].Transactions.Add(Transaction);

            setAccounts(accounts); //export to database
            UpdateBalances();
        }
        private static void NewTransaction(string AccountID, string TransactionID, string TransferAccountId, DateTime Date, string Number = "", string Description = "", long Amount = 0)
        {
            Transaction transaction = new Transaction(Id: TransactionID, TransferId: TransferAccountId, Date: Date, Number: Number, Description: Description, Amount: Amount);

            NewTransaction(AccountID, transaction);
        }
        public static void NewTransaction(string AccountID, string TransferAccountId, DateTime Date, string Number = "", string Description = "", long Amount = 0)
        {
            string transactionId = IdGenerator.GenerateID(AccountID);

            NewTransaction(AccountID: AccountID, TransactionID: transactionId, TransferAccountId: TransferAccountId, Date: Date, Number: Number, Description: Description, Amount: Amount);
        }
        public static void DeleteTransaction(string TransactionId)
        {
            List<Account> accounts = GetAccounts(); //import from database

            List<int> accountIndices = new List<int>();
            List<int> transactionIndices = new List<int>();

            //index accounts with transactions and transactions
            foreach (Account account in accounts)
            {
                foreach (Transaction transaction in account.Transactions)
                {
                    if (transaction.Id == TransactionId)
                    {
                        string accountId = account.Id;
                        int accountIndex = GetAccountIndex(accountId);

                        int transactionIndex = getTransactionIndex(accountId: accountId, transactionId: TransactionId);

                        transactionIndices.Add(transactionIndex);
                        accountIndices.Add(accountIndex);
                    }
                }
            }

            //nuke all indexed transactions
            for (int i = 0; i < accountIndices.Count; i++)
            {
                accounts[accountIndices[i]].Transactions.RemoveAt(transactionIndices[i]);
            }

            db_ZappCash.Accounts = accounts; //export to database
            UpdateBalances();
        }
        public static void EditTransaction(string AccountId, string TransactionId, DateTime? Date = null, string Number = null, string Description = null, string TransferId = null, long? Amount = null)
        {            
            Transaction transaction = GetTransaction(AccountId: AccountId, TransactionId: TransactionId);

            if (Date != null) { transaction.Date = (DateTime)Date; }
            if (Number != null) { transaction.Number = Number; }
            if (Description != null) { transaction.Description = Description; }
            if (TransferId != null) { transaction.TransferId = TransferId; }
            if (Amount != null) { transaction.Amount = (long)Amount; }

            DeleteTransaction(TransactionId);
            NewTransaction(AccountID: AccountId, Transaction: transaction);
            UpdateBalances();
        }

    }
}

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
        public static List<Account> GetAccounts()
        {
            return db_ZappCash.Accounts;
        }

        private static void setAccounts(List<Account> accounts)
        {
            db_ZappCash.Accounts = accounts;
            FileManager.TempSave();
        }

        public static void New()
        {
            db_ZappCash.CheckIntegrity();
            deleteAccounts();

            List<zc_DefaultAccountsProperty> defaultAccounts = db_ZappCash.Defaults.AccountDefaults.Accounts;

            foreach (zc_DefaultAccountsProperty defaultAccountProperties in defaultAccounts)
            {
                string parentId = GetAccountId(defaultAccountProperties.parent);
                NewAccount(Name: defaultAccountProperties.name, IsPlaceholder: defaultAccountProperties.isPlaceholder, ParentId: parentId);
            }
        }

        //General Actions
        public static void UpdateBalances()
        {
            List<Account> accounts = db_ZappCash.Accounts;
            accounts.Reverse();

            foreach (Account account in accounts)
            {
                long accountBalance = 0;
                foreach (Transaction transaction in account.Transactions)
                {
                    accountBalance += transaction.Amount;
                    transaction.Balance = accountBalance;
                }

                foreach (Account child in GetAccountChildren(AccountId: account.Id))
                {
                    accountBalance += child.Balance;
                }
                account.Balance = accountBalance;
            }
            accounts.Reverse();
            setAccounts(accounts);
            FileManager.TempSave();
        }

        private static void sortAccounts()
        {
            List<Account> accounts = db_ZappCash.Accounts;
            accounts = accounts.OrderBy(account => GetLongAccountName(account.Id)).ToList();
            db_ZappCash.Accounts = accounts;
        }

        private static void sortTransations()
        {
            List<Account> accounts = db_ZappCash.Accounts;
            foreach (Account account in accounts)
            {
                account.Transactions = account.Transactions.OrderBy(s => s.Date).ThenBy(s => s.Number).ToList();
            }
        }


        //Accounts
        //get
        public static Account GetAccount(string AccountId)
        {
            List <Account> accounts = GetAccounts(); //import from database
            
            int accountIndex = GetAccountIndex(AccountId: AccountId);

            Account account;

            if (accountIndex < 0)
            {
                account = new Account(id: db_ZappCash.Defaults.AccountDefaults.ParentId, attributes: new AccountAttributes("Root", "", "", "", ""), assetType: db_ZappCash.Defaults.AccountDefaults.AssetType, isPlaceholder: true, null, db_ZappCash.Defaults.AccountDefaults.Decimals);
            }
            else
            {
                account = accounts[accountIndex];
            }

            return account;
        }
        public static int GetAccountIndex(string AccountId)
        {
            List<Account> accounts = GetAccounts();
            int accountIndex = accounts.FindIndex(x => x.Id.Equals(AccountId));
            return accountIndex;
        }

        public static List<Account> GetAccountChildren(string AccountId)
        {
            List<Account> accounts = GetAccounts();
            List<Account> childAccounts = new List<Account>();
            foreach (Account account in accounts)
            {
                if (account.ParentId == AccountId)
                {
                    childAccounts.Add(account);
                }
            }

            return childAccounts;
        }


        public static string GetAccountId(string accountName)
        {
            List<Account> accounts = GetAccounts();
            foreach (Account account in accounts)
            {
                if (account.Attributes.Name == accountName)
                {
                    return account.Id;
                }
            }
            return null;
        }


        public static string GetAccountId(string ParentAccountId, string AccountName)
        {
            List<Account> accounts = GetAccountChildren(ParentAccountId);
            foreach (Account account in accounts)
            {
                if (account.Attributes.Name == AccountName)
                {
                    return account.Id;
                }
            }
            return null;
        }



        //new
        private static void NewAccount(Account Account)
        {
            List<Account> accounts = GetAccounts();
            accounts.Add(Account);
            setAccounts(accounts);
            sortAccounts();
        }
        public static void NewAccount(string ParentId = null, byte Decimals = 2, string Name = "", string Code = "", string Description = "", string Color = "#ffffff", string Notes = "", string AssetType = "PHP", bool IsPlaceholder = false)
        {
            AccountAttributes accountAttributes = new AccountAttributes(name: Name, code: Code, description: Description, color: Color, notes: Notes);

            string accountId;

            if (ParentId == null)
            {
                string parentId = db_ZappCash.Defaults.AccountDefaults.ParentId;
                accountId = IdGenerator.GenerateID(parentId);
            }
            else
            {
                accountId = IdGenerator.GenerateID(ParentId);
            }

            Account account = new Account(id: accountId, attributes: accountAttributes, assetType: AssetType, isPlaceholder: IsPlaceholder, parentId: ParentId, decimals: Decimals);

            NewAccount(account);
        }

        //delete
        private static void deleteAccount(string accountId) //raw delete an account from database
        {
            List<Account> accounts = GetAccounts(); //get from database
            int accountIndex = GetAccountIndex(accountId); //get account index
            accounts.RemoveAt(accountIndex); //delete account
            setAccounts(accounts); //write to database
            UpdateBalances();
        }
        
        private static void deleteAccounts()
        {
            db_ZappCash.Accounts = new List<Account>();
        } //delete all acocunts
        
        private static void deleteAccounts(string[] accountIds)
        {
            foreach (string accountId in accountIds)
            {
                deleteAccount(accountId);
            }
        } //delete selected accounts

        public static void DeleteAccount(string AccountId, bool DeleteTransactions = true, bool DeleteChildren = true)
        {
            List<Account> accounts = GetAccounts(); //read from database
            List<string> selectedAccounts = new List<string>();

            if (DeleteChildren)
            {
                foreach (Account account in accounts)
                {
                    if (account.ParentId == AccountId)
                    {
                        selectedAccounts.Add(account.Id);
                    }
                }
                
                foreach (string accountId in selectedAccounts)
                {
                    DeleteAccount(AccountId: accountId, DeleteTransactions = true, DeleteChildren = true);
                }

            }

            if (DeleteTransactions)
            {
                List<string> selectedtransactions = new List<string>();
                {
                    foreach (Transaction transaction in GetTransactions(AccountId))
                    {
                        selectedtransactions.Add(transaction.Id);
                    }
                }

                foreach (string transactionid in selectedtransactions)
                {
                    DeleteTransaction(transactionid);
                }
            }

            deleteAccount(AccountId);
        }
        

        //edit
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
            if (ParentId == db_ZappCash.Defaults.AccountDefaults.ParentId) { account.ParentId = null; }
            if (Decimals != null) { account.Decimals = (byte)Decimals; }


            DeleteAccount(AccountId, false, false);
            NewAccount(account);
            UpdateBalances();
        }
        
        //Transactions
        public static Transaction GetTransaction(string AccountId,string TransactionId)
        {
            UpdateBalances();
            List<Account> accounts = GetAccounts(); //import from database
            
            int accountIndex = GetAccountIndex(AccountId: AccountId);
            int transactionIndex = getTransactionIndex(accountId: AccountId, transactionId: TransactionId);

            Transaction transaction = accounts[accountIndex].Transactions[transactionIndex];

            return transaction;
        }

        
        public static List<Transaction> GetTransactions(string AccountId)
        {
            Account account = GetAccount(AccountId);
            List<Transaction> transactions = account.Transactions;
            return transactions;
        }
        
        private static int getTransactionIndex(string accountId, string transactionId)
        {
            List<Account> accounts = GetAccounts(); //import from database
            int accountIndex = GetAccountIndex(AccountId: accountId);

            Account account = accounts[accountIndex];

            int transactionIndex = account.Transactions.FindIndex(x => x.Id.Equals(transactionId));

            return transactionIndex;
        }
        
        private static void NewTransaction(string accountId, Transaction transaction)
        {
            //if (GetAccount(accountId).IsPlaceholder)
            if (false)
            {
                throw new InvalidOperationException($"Account {accountId} is a placeholder account and cannot contain any transactions.");
            } //no transactions in placeholders
            
            List<Account> accounts = GetAccounts(); //import from database
            int accountIndex = GetAccountIndex(accountId);

            accounts[accountIndex].Transactions.Add(transaction);
            
            setAccounts(accounts); //export to database
            sortTransations();
            UpdateBalances();
        } //raw new transaction
        
        private static void NewTransaction(string AccountID, string TransactionID, string TransferAccountId, DateTime Date, string Number = "", string Description = "", long Amount = 0) //with transaction id
        {
            Transaction transaction = new Transaction(Id: TransactionID, TransferId: TransferAccountId, Date: Date, Number: Number, Description: Description, Amount: Amount);
            NewTransaction(AccountID, transaction);

            Transaction mirrorTransaction = new Transaction(Id: TransactionID, TransferId: AccountID, Date: Date, Number: Number, Description: Description, Amount: -Amount);
            NewTransaction(TransferAccountId, mirrorTransaction);
        }
        
        public static void NewTransaction(string AccountID, string TransferAccountId, DateTime? Date = null, string Number = "", string Description = "", long Amount = 0)
        {
            DateTime date;
            if (Date == null) { date = DateTime.Today; }
            else { date = Convert.ToDateTime(Date); }
            
            string transactionId = IdGenerator.GenerateID(AccountID);
            NewTransaction(AccountID: AccountID, TransactionID: transactionId, TransferAccountId: TransferAccountId, Date: date, Number: Number, Description: Description, Amount: Amount);
        } //no transaction id
        
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
            NewTransaction(AccountID: AccountId, TransactionID: TransactionId, TransferAccountId: transaction.TransferId, Date: transaction.Date, Number: transaction.Number, Description: transaction.Description, Amount: transaction.Amount);

            sortTransations();
            UpdateBalances();
        }

        public static string GetLongAccountName(string Id)
        {
            Account account = GetAccount(Id);
            string parentLongAccountName = "";

            if (account.ParentId != null)
            {
                parentLongAccountName = GetLongAccountName(account.ParentId);
                return $"{parentLongAccountName}:{account.Attributes.Name}";
            }
            
            return $"{account.Attributes.Name}";
        }

        


    }
}

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
        public string FileLocation;
        
        //initialize
        public AccountsControl()
        {

        }
        public AccountsControl(string filePath)
        {
            FileLocation = filePath;
            open();
        }


        //methods
        public void open()
        {
        }

        public List<Account> OpenAccounts()
        {
            jsonFile hi = new jsonFile(FileLocation);
            List<Account> accounts = JsonConvert.DeserializeObject<List<Account>>(hi.jsonContent);
            return accounts;
        }
    }
}

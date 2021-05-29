using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordManager2._0
{
    class AccountCollection
    {
        private List<Account> mAllAccounts = new List<Account>();
        Account mThisAccount = new Account();

        public List<Account> AccountList
        {
            get
            {
                return mAllAccounts;
            }
            set
            {
                mAllAccounts = value;
            }
        }
    }
}

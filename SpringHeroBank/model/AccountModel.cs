using System.Collections.Generic;
using SpringHeroBank.entity;

namespace SpringHeroBank.model
{
    public class AccountModel
    {
        
        public bool Save(Account account)
        {
            return false;
        }
        
        public Account FindById(string id)
        {
            return null;
        }
        
        public List<Account> FindAll()
        {
            return new List<Account>();
        }

        public bool Update(string id, Account updateAccount)
        {
            return false;
        }

        public bool Delete(string id)
        {
            return false;
        }
    }
}
using SpringHeroBank.entity;
using SpringHeroBank.model;

namespace SpringHeroBank.service
{
    public class AccountService
    {
        private AccountModel _accountModel = new AccountModel();

        public void CreateAccount(Account account)
        {
            // làm rất nhiều việc ở đây.
            _accountModel.Save(account);
        }
    }
}
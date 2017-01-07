using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FlowerShop.Models;

namespace FlowerShop.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private EcommercEntities ecommercEntities = new EcommercEntities();

        public void creat(Account account)
        {
            ecommercEntities.Accounts.Add(account);
            ecommercEntities.SaveChanges();
        }

        public Account login(string username, string password)
        {
            try
            {

                return ecommercEntities.Accounts.Single(account => account.username.Equals(username) &&
                account.password.Equals(password));
            }
            catch
            {

                return null;
            }
        }
    }
}
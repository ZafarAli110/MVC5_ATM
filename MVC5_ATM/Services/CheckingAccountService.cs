using MVC5_ATM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC5_ATM.Services
{
    public class CheckingAccountService
    {
        private ApplicationDbContext dbContext;

        public CheckingAccountService(ApplicationDbContext db)
        {
            dbContext = db;
        }

        public void CreateCheckingAccount(string firstName, string lastName ,string userId , decimal initialBalance)
        {
            var accountNumber = (123456 + dbContext.CheckingAccounts.Count()).ToString().PadLeft(10, '0');
            var checkingAccount = new CheckingAccount
            {
                FirstName = firstName,
                LastName = lastName,
                AccountNumber = accountNumber,
                Balance = initialBalance,
                ApplicationUserId = userId
            };
            dbContext.CheckingAccounts.Add(checkingAccount);
            dbContext.SaveChanges();
        }
    }
}
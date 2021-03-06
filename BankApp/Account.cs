﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp
{
    enum AccountType
    {
        Checking,
        Savings,
        Loan,
        CD
    }
    class Account
    {
        // Regular Comment
        /* Multiple Line 
         * Comment
         **/
        /// <summary>
        /// XML Comment
        /// </summary>

        private static int lastAccountNumber = 0;
        #region Properties
        public int AccountNumber { get; private set; }
        public string AccountName { get; set; }
        public DateTime CreatedDate { get; private set; }
        public decimal Balance { get; private set; }
        public AccountType TypeOfAccount { get; set; }
        public string EmailAddress { get; set; }
        #endregion

        #region Constructors
        public Account()
        {
            AccountNumber = ++lastAccountNumber;
            CreatedDate = DateTime.Now;
        }

        #endregion

        #region Methods
        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public decimal Withdraw(decimal amount)
        {
            Balance -= amount;
            return Balance;
        }
        #endregion

    }
}

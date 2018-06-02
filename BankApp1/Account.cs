using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankApp1
{
    /// <summary>
    /// Bank acoount 
    /// </summary>
    class Account
    {
        #region Properties
        /// <summary>
        /// Unique Account Number for the classs
        /// </summary>
        public int AccountNumber { get; set; }
        /// <summary>
        /// customer email adress corresponding to Account number
        /// </summary>
        public String EmailAddress { get; set; }
        /// <summary>
        /// Balance in the account 
        /// </summary>
        public decimal Balance { get; private set; }
        /// <summary>
        /// The type of account 
        /// </summary>
        public string TypeOfAccount { get; private set; }
        /// <summary>
        /// the date the account was created
        /// </summary>
        public DateTime CreatedDate { get; set; }
        #endregion
        #region Methods
        /// <summary>
        /// Deposit money into your account
        /// </summary>
        /// <param name="amount">amount you deposited into the account</param>
        /// <returns>updated balance</returns>
        public decimal Deposit(decimal amount)
        {
            //Balance=Balance+amount
            Balance += amount;
            return Balance;
        }
        /// <summary>
        /// withdraw money from the account
        /// </summary>
        /// <param name="amount">the amount you want to withdraw</param>
        public void Withdraw(decimal amount)
        {
            Balance -= amount;
        }
        #endregion
    }
}

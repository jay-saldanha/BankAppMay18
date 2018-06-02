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
        public decimal Balance { get; set; }
        /// <summary>
        /// The type of account 
        /// </summary>
        public string TypeOfAccount { get; set; }
        #endregion
    }
}

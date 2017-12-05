using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow
{
    class Client
    {
        /// <summary>
        /// Variables
        /// </summary>
        public string Name { get; private set; }  // Name of account holder
        public int Balance { get; private set; }  // Current balance

        /// <summary>
        /// Create client with specific name and beginning balance
        /// </summary>
        /// <param name="name">Name of account holder</param>
        /// <param name="balance">Beginning balance value</param>
        public Client(string name, int balance)
        {
            SetName(name);
            SetBalance(balance);
        }

        /// <summary>
        /// Create client with specific name and zero balance
        /// </summary>
        /// <param name="name">Name of account holder</param>
        public Client(string name) : this(name, 0)
        {
            ;
        }

        /// <summary>
        /// Set new clients name
        /// </summary>
        /// <param name="name">New name of account holder</param>
        public void SetName(string name)
        {
            this.Name = name;
        }

        /// <summary>
        /// Set new client balance
        /// </summary>
        /// <param name="balance">New balance value</param>
        public void SetBalance(int balance)
        {
            this.Balance = balance;
        }
    }
}

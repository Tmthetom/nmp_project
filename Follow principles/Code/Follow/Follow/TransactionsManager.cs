using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow
{
    class TransactionsManager
    {
        /// <summary>
        /// Singleton
        /// </summary>
        static readonly TransactionsManager instance = new TransactionsManager();
        public static TransactionsManager Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Create transaction manager
        /// </summary>
        public TransactionsManager()
        {

        }

        /// <summary>
        /// Transfer money from one client to another
        /// </summary>
        /// <param name="from">Client sending mouney</param>
        /// <param name="to">Client receiving money</param>
        /// <param name="value">Sending value</param>
        public void TransferMoney(Client from, Client to, int value)
        {
            if (from == null) throw new Exception("Sender dont exist");
            if (to == null) throw new Exception("Receiver dont exist");
            if (from.Balance < value) throw new Exception("Send have not enought money to send specified value");

            from.SetBalance(from.Balance - value);
            to.SetBalance(to.Balance + value);
        }
    }
}

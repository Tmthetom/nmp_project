using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow
{
    class Bank
    {
        /// <summary>
        /// Singleton
        /// </summary>
        static readonly Bank instance = new Bank();
        public static Bank Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Variables
        /// </summary>
        private ClientManager clientManager;
        private TransactionsManager transactionsManager;

        /// <summary>
        /// Create one and only bank
        /// </summary>
        public Bank()
        {
            clientManager = new ClientManager();
            transactionsManager = new TransactionsManager();
        }

        /// <summary>
        /// Add one new client
        /// </summary>
        /// <param name="name">Account holder name</param>
        public void AddClient(string name)
        {
            clientManager.Add(name);
        }

        /// <summary>
        /// Add one new client
        /// </summary>
        /// <param name="name">Account holder name</param>
        /// <param name="balance">Beginning balance value</param>
        public void AddClient(string name, int balance)
        {
            clientManager.Add(name, balance);
        }

        /// <summary>
        /// Remove selected client
        /// </summary>
        /// <param name="client">Client object</param>
        public void RemoveClient(Client client)
        {
            clientManager.Remove(client);
        }

        /// <summary>
        /// Transfer money from one client to another
        /// </summary>
        /// <param name="from">Client sending mouney</param>
        /// <param name="to">Client receiving money</param>
        /// <param name="value">Sending value</param>
        public void TransferMoney(Client from, Client to, int value)
        {
            transactionsManager.TransferMoney(from, to, value);
        }

        /// <summary>
        /// Return all clients
        /// </summary>
        /// <returns></returns>
        public List<Client> GetClients()
        {
            return clientManager.Clients;
        }
    }
}

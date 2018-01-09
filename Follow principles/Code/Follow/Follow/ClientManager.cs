using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow
{
    class ClientManager
    {
        /// <summary>
        /// Singleton
        /// </summary>
        static readonly ClientManager instance = new ClientManager();
        public static ClientManager Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Variables
        /// </summary>
        public List<Client> Clients { get; private set; }

        /// <summary>
        /// Create one and only client manager
        /// </summary>
        private ClientManager()
        {
            Clients = new List<Client>();
        }

        /// <summary>
        /// Add one new client
        /// </summary>
        /// <param name="name">Account holder name</param>
        public void Add(string name)
        {
            Client client = new Client(name);
            Clients.Add(client);
        }

        /// <summary>
        /// Add one new client with specific balance
        /// </summary>
        /// <param name="name">Account holder name</param>
        /// <param name="balance">Beginning balance</param>
        public void Add(string name, int balance)
        {
            Client client = new Client(name, balance);
            Clients.Add(client);
        }

        /// <summary>
        /// Remove selected client
        /// </summary>
        /// <param name="client">Client object</param>
        public void Remove(Client client)
        {
            Clients.Remove(client);
        }
    }
}

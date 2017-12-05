using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Bank
    {
        public List<User> List { get; private set; }

        public Bank()
        {
            List = new List<User>();
        }

        public void New(string name)
        {
            User client = new User(name);
            List.Add(client);
        }

        public void New(string name, int balance)
        {
            User client = new User(name, balance);
            List.Add(client);
        }

        public void Del(User client)
        {
            List.Remove(client);
        }

        public void Give(User A, User B, int val)
        {
            if (A == null) throw new Exception("Sender dont exist");
            if (B == null) throw new Exception("Receiver dont exist");
            if (A.Value < val) throw new Exception("Send have not enought money to send specified value");

            A.NewVal(A.Value - val);
            B.NewVal(B.Value + val);
        }

        public List<User> Clients()
        {
            return List;
        }
    }
}

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

        public void New(string text)
        {
            User client = new User(text);
            List.Add(client);
        }

        public void New(string text, int value)
        {
            User client = new User(text, value);
            List.Add(client);
        }

        public void Del(User user)
        {
            List.Remove(user);
        }

        public void Give(User A, User B, int val)
        {
            if (A == null) throw new Exception("Sender does not exist");
            if (B == null) throw new Exception("Receiver does not exist");
            if (A.Value < val) throw new Exception("Sender does not have enought money to send specified value");

            A.NewVal(A.Value - val);
            B.NewVal(B.Value + val);
        }

        public List<User> Users()
        {
            return List;
        }
    }
}

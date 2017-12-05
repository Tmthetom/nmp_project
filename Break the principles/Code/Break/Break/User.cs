using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class User
    {
        public string Text { get; private set; }
        public int Value { get; private set; }

        public User(string text, int value)
        {
            NewText(text);
            NewVal(value);
        }

        public User(string text) : this(text, 0)
        {
            ;
        }

        public void NewText(string newText)
        {
            this.Text = newText;
        }

        public void NewVal(int newValue)
        {
            this.Value = newValue;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Break
{
    class Program
    {
        static Bank bank;

        static void Main(string[] args)
        {
            bank = new Bank();
            bank.New("Miloš Zeman", -10);
            bank.New("Jiří Drahoš", 5000);

            int selected = 0;
            do
            {
                PrintMenu();
                selected = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (selected)
                {
                    case 1:
                        ShowClients();
                        break;
                    case 2:
                        DoTransaction();
                        break;
                    case 3:
                        selected = -1;
                        break;
                }

                Console.WriteLine("Press any key to continue...");
                Console.ReadLine();
            }
            while (selected != -1);
        }

        private static void PrintMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Welcome in bank administration!");
            Console.WriteLine();
            Console.WriteLine("Please select one option:");
            Console.WriteLine("1. Show clients");
            Console.WriteLine("2. Do transaction");
            Console.WriteLine("3. Finish");
            Console.WriteLine();
            Console.Write("Selected option: ");
        }

        private static void ShowClients()
        {
            Console.WriteLine();
            List<User> clients = bank.Clients();
            foreach (User client in clients)
            {
                Console.WriteLine("[" + clients.IndexOf(client) + "] " + client.Text + ":\t" + client.Value + " Kč");
            }
            Console.WriteLine();
        }

        private static void DoTransaction()
        {
            int index;
            int value;
            User from;
            User to;

            try
            {
                Console.WriteLine("Please select FROM (sender):");
                ShowClients();
                Console.Write("FROM: ");
                index = Convert.ToInt32(Console.ReadLine());
                from = bank.Clients()[index];

                Console.WriteLine("\nPlease select TO (receiver):");
                ShowClients();
                Console.Write("TO: ");
                index = Convert.ToInt32(Console.ReadLine());
                to = bank.Clients()[index];

                Console.WriteLine("\nPlease select value to be sender from " + from.Text + ", to " + to.Text);
                Console.Write("Value = ");
                value = Convert.ToInt32(Console.ReadLine());
                bank.Give(from, to, value);

                ShowClients();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

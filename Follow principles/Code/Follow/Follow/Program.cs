using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Follow
{
    class Program
    {
        static Bank bank;

        static void Main(string[] args)
        {
            bank = new Bank();
            bank.AddClient("Miloš Zeman", -10);
            bank.AddClient("Jiří Drahoš", 5000);

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
            List<Client> clients = bank.GetClients();
            foreach (Client client in clients)
            {
                Console.WriteLine("[" + clients.IndexOf(client) + "] " + client.Name + ":\t" + client.Balance + " Kč");
            }
            Console.WriteLine();
        }

        private static void DoTransaction()
        {
            int index;
            int value;
            Client from;
            Client to;

            try
            {
                Console.WriteLine("Please select FROM (sender):");
                ShowClients();
                Console.Write("FROM: ");
                index = Convert.ToInt32(Console.ReadLine());
                from = bank.GetClients()[index];

                Console.WriteLine("\nPlease select TO (receiver):");
                ShowClients();
                Console.Write("TO: ");
                index = Convert.ToInt32(Console.ReadLine());
                to = bank.GetClients()[index];

                Console.WriteLine("\nPlease select value to be sender from " + from.Name + ", to " + to.Name);
                Console.Write("Value = ");
                value = Convert.ToInt32(Console.ReadLine());
                bank.TransferMoney(from, to, value);

                ShowClients();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccounting.Class
{
    public class ListClients
    {
        public static List<Client> _clients;

        static ListClients()
        {
            _clients = new List<Client>();
            if (File.Exists("clients.txt"))
            {
                string[] lines = File.ReadAllLines("clients.txt");
                for (int i = 0; i < lines.Length; i += 5)
                {
                    string name = lines[i];
                    string telephone = lines[i + 1];
                    string address = lines[i + 2];
                    string OrderName = lines[i + 3];
                    DateTime dataTime = DateTime.Parse(lines[i + 4]);
                    _clients.Add(new Client(name, telephone, address, OrderName) { DataTime = dataTime });
                }
            }
        }
        public static StringBuilder ShowClients()
        {   
            var count = 1;  
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < _clients.Count; i++)
            {   
                sb.Append(count + "\n");
                sb.Append(_clients[i].ToString() + "\n");
                count++;
            }
            return sb;
        }

        public static void AddClients(Client client)
        {
            _clients.Add(client);
            WriteClientsToFile();
        }
        public static void DeleteClients(Client client)
        {
            _clients.Remove(client);
            WriteClientsToFile();
        }
        private static void WriteClientsToFile()
        {
            using (StreamWriter writer = new StreamWriter("clients.txt", false)) // false означает, что файл будет перезаписан
            {
                foreach (var client in _clients)
                {
                    writer.WriteLine($"{client.Name}\n{client.Telephone}\n{client.Address}\n{client.OrderName}\n{client.DataTime}");
                }
            }
        }
    }
}

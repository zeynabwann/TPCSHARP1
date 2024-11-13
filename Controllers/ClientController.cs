using Microsoft.AspNetCore.Mvc;
using Name.Models;

namespace Name.Controller
{
    public class ClientController
    {
        private List<Client> clients;  
 }
public void Insert(Client client)
        {
            clients.Add(client);
        }

        public ClientController()
        {
            clients = new List<Client>();
        }

        public void Update(Client client)
        {
            int position = clients.FindIndex(cl => cl.Id == client.Id);
            if (position != -1)
                clients[position] = client;
        }
        public void Delete(int id)
        {
            Client clientToRemove = clients.Find(cl => cl.Id == id);
            if (clientToRemove != null)
                clients.Remove(clientToRemove);
        }
    }




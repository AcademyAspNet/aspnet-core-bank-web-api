using _BankWebAPI.Data;
using _BankWebAPI.Data.Entities;
using _BankWebAPI.Models.DTOs;

namespace _BankWebAPI.Services.Implementations
{
    public class ClientService : IClientService
    {
        private readonly ApplicationDbContext _database;

        public ClientService(ApplicationDbContext database)
        {
            _database = database;
        }

        public IList<Client> GetClients(long fromClientId, int count)
        {
            throw new NotImplementedException();
        }

        public Client? GetClientById(long clientId)
        {
            throw new NotImplementedException();
        }

        public Client CreateClient(ClientDto clientDto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteClientById(long clientId)
        {
            throw new NotImplementedException();
        }
    }
}

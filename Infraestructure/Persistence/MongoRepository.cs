using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace Infraestructure.Persistence
{
    public class MongoRepository : IUserRepository
    {
        private readonly IMongoCollection<User> _users;

        public MongoRepository(IConfiguration config)
        {
            var client = new MongoClient(config.GetConnectionString("MongoDb"));
            var database = client.GetDatabase("CatAppDB");
            _users = database.GetCollection<User>("Users");
        }

        public async Task<User?> LoginAsync(string username, string password)
        {
            return await _users.Find(u => u.Username == username && u.Password == password).FirstOrDefaultAsync();
        }

        public async Task RegisterAsync(User user)
        {
            await _users.InsertOneAsync(user);
        }
    }
}

using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interfaces
{
    public interface IUserRepository
    {
        Task<User?> LoginAsync(string username, string password);
        Task RegisterAsync(User user);
    }
}

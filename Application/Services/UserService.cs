using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Services
{
    public class UserService(IUserRepository _userRepo)
    {
        public async Task<User?> Login(string user, string pass) => await _userRepo.LoginAsync(user, pass);

        public async Task Register(string user, string pass)
        {
            // Validaciones de negocio aquí
            var newUser = new User { Username = user, Password = pass };
            await _userRepo.RegisterAsync(newUser);
        }
    }
}

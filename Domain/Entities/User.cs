using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Text;
namespace Domain.Entities
{
    public class User
    {
        public ObjectId Id { get; set; }
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}

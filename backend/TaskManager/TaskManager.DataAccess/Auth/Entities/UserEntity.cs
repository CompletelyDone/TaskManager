﻿using TaskManager.Core.Auth.Models;

namespace TaskManager.DataAccess.Auth.Entities
{
    public class UserEntity
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string HashedPassword { get; set; }
        public Role Role { get; set; }
    }
}

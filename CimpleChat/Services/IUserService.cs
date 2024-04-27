﻿using CimpleChat.Models;

namespace CimpleChat.Services
{
    public interface IUserService
    {
        public User AddNewUser(string userName);
        public IList<User> GetUsers();
        public User GetUser(long userId);
    }
}
using System;
using dotnet_WebAPI.Models;

namespace dotnet_WebAPI.Data
{
    public interface IUserRepository
    {
        User Create(User user);
        User GetByEmail(string email);
        User GetById(int id);
    }
}

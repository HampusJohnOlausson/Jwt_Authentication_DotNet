using System;
using System.Linq;
using dotnet_WebAPI.Models;

namespace dotnet_WebAPI.Data
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public User Create(User user)
        {
            _context.Users.Add(user);
            user.Id = _context.SaveChanges();

            return user;
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(User => User.Email == email);
        }

        public User GetById(int id)
        {
            return _context.Users.FirstOrDefault(User => User.Id == id);
        }

    }
}

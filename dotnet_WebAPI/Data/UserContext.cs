using System;
using dotnet_WebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace dotnet_WebAPI.Data
{
    public class UserContext : DbContext
    { 
        public UserContext(DbContextOptions<UserContext> options) : base(options)
        {

        }

        public DbSet<User> Users { set; get; }

    }
}

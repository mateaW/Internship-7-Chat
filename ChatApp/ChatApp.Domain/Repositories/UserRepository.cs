using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using ChatApp.Data.Entities;
using ChatApp.Data.Entities.Models;
using ChatApp.Domain.Enums;

namespace ChatApp.Domain.Repositories
{
    public class UserRepository : BaseRepository
    {
        public UserRepository(ChatAppDbContext dbContext) : base(dbContext)
        {

        }
        public ResponseResultType Add(User user)
        {
            DbContext.Users.Add(user);
            return SaveChanges();
        }
        public ResponseResultType Delete(int id)
        {
            var userToDelete = DbContext.Users.Find(id);
            if (userToDelete is null)
            {
                return ResponseResultType.NotFound;
            }

            DbContext.Users.Remove(userToDelete);
            return SaveChanges();
        }
        public ResponseResultType Update(User user, int id)
        {
            var userToUpdate = DbContext.Users.Find(id);
            if (userToUpdate is null)
            {
                return ResponseResultType.NotFound;
            }

            userToUpdate.Email = user.Email;
            userToUpdate.UserName = user.UserName;
            return SaveChanges();
        }

        public User? GetByEmail(string email) => DbContext.Users.FirstOrDefault(u => u.Email == email);
        public User? GetById(int id) => DbContext.Users.FirstOrDefault(u => u.Id == id);
    }
}

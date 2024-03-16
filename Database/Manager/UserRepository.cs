using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp.Database;
using ConsoleApp.Models;
using ConsoleApp.Repository;

namespace ConsoleApp.Database.Manager
{
    public class UserRepository : IDatabaseRepository<UserModel>
    {
        private readonly DatabaseContext _dbContext;

        public UserRepository(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void Create(UserModel user)
        {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }

        public UserModel GetById(int id)
        {
            return _dbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public void Update(UserModel user)
        {
            _dbContext.Users.Update(user);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
            var user = _dbContext.Users.FirstOrDefault(u => u.Id == id);
            if (user != null)
            {
                _dbContext.Users.Remove(user);
                _dbContext.SaveChanges();
            }
        }
    }
}

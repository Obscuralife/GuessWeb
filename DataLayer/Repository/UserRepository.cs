using DataLayer.Context;
using DataLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
    public class UserRepository
    {
        DataContext DataContext { get; }
        public UserRepository(DataContext dataContext)
        {
            this.DataContext = dataContext;
        }

        public User Save(User user)
        {
            this.DataContext.Users.Add(user);
            this.DataContext.SaveChanges();
            return user;
        }
        public User Remove(long id)
        {
            var user = this.DataContext.Users.SingleOrDefault(x => x.Id == id);
            if (user != null)
            {
                this.DataContext.Remove(user);
                this.DataContext.SaveChanges();
                return user;
            }
            return null;
        }
        public List<User> GetAllUsers()
        {
            return DataContext.Users.ToList();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class UserAccount
    {
        public int Id { get; private set; }
        private readonly string _login;
        private readonly string _password;

        public User User { get; private set; }
        public List<UserHistory> History { get; private set; }

        public UserAccount()
        {
            this.History = new List<UserHistory>();
            History.Add(new UserHistory("Create account"));
        }

        public void AddUserHistory(string message)
        {
            this.History.Add(new UserHistory(message));
        }

        public void CreateUser(string firstName, string secondName)
        {
            this.User = new User(firstName, secondName);
            this.History.Add(new UserHistory("Created User"));
        }
    }
}

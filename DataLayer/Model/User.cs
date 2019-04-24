using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class User
    {
        public string FirstName { get; private set; }
        public string SeconName { get; private set; }

        public User(string firstName, string secondName)
        {
            this.FirstName = firstName;
            this.SeconName = secondName;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class User
    {
        public long Id { get; private set; }
        public string Name { get;  set; }
        public string Password { get;  set; }
        public ulong Score { get; set; }
    }
}

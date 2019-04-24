using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.Model
{
    public class UserHistory
    {
        public UserHistory(string message)
        {
            this.Message = message;
            this.Time = DateTime.Now;
        }

        public string Message { get; private set; }
        public DateTime Time { get; private set; }

    }
}

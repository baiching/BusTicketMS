using System;
using Entity.UserModels;

namespace Entity.Logs
{
    public class UserLog : Log
    {
        public DateTime LogDateTime { get; set; }
        public Role Role { get; set; }

    }
}

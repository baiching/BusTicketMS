using Entity.BusModels;
using Entity.Logs;
using Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL
{
    public class Context : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Bus> Buses { get; set; }
        public DbSet<BusCompany> BusCompanies { get; set; }
        public DbSet<Offer> Offers { get; set; }
        public DbSet<Stopage> Stopages { get; set; }
        public DbSet<SearchLog> SearchLogs { get; set; }
        public DbSet<UserLog> UserLogs { get; set; }

        public Context()
        {
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}

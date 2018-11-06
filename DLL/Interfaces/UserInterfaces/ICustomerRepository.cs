using Entity.BusModels;
using Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.Interfaces.UserInterfaces
{
    public interface ICustomerRepository : IUserRepository<Customer>
    {
        bool Delete(string id);
        bool CancelTicket(int TicketId);
        bool PurchaseTicket(DateTime journeyDay, string Destination, BusType busType);
        IEnumerable<Customer> GetTicketList();
    }
}

using Entity.UserModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BusModels
{
    public class BusTicket
    {
        public int TicketId { get; set; }
        public User User { get; set; }
        public DateTime JourneyDay { get; set; }
        public string Destination { get; set; }
        public int BusId { get; set; }
        public int TripId { get; set; }
        public string EndPoint { get; set; }
        public virtual Trip Trip { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BusModels
{
    public class Trip
    {
        public int TripId { get; set; }
        public DateTime DepartureTime { get; set; }
        public string StartPoint { get; set; }
        public string EndPoint { get; set; }
        public int SeatAvailable { get; set; }
        public int BusId { get; set; }
        public virtual Bus Bus { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BusModels
{
    public class Offer
    {
        public int OfferId { get; set; }
        public string OfferTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public string Description { get; set; }
        public BusCompany BusCompany { get; set; }
    }
}

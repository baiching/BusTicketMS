using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.BusModels
{
    public class BusCompany
    {
        public int BusCompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public int Fare { get; set; }
        public List<Bus> Bus { get; set; }

        public BusCompany()
        {
            Bus = new List<Bus>();
        }
    }
}

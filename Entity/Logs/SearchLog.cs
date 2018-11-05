using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;

namespace Entity.Logs
{

    public class SearchLog
    {
        public string Location { get; set; }
        public string BusType { get; set; }
        public string Destination { get; set; }

        public string LocationsList
        {
            get => string.Join(",", LocationList);
            set => LocationList = value.Split(',').ToList();
        }


        [NotMapped]
        public List<string> LocationList { get; set; }
    }
}

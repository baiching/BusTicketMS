namespace Entity.BusModels
{
    public enum BusType { AC = 1, NonAC = 2}
    public class Bus
    {
        public int BusId { get; set; }
        public BusType BusType { get; set; }
        public int BusNumber { get; set; }
        public BusCompany BusCompany { get; set; }
        public int TotalSeat { get; set; }
        public Stopage Stopage { get; set; }
    }
}
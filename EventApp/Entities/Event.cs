namespace EventApp.Entities
{

    public class Event
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Purpose> Purpose { get; set; }
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int AcceptStatusId { get; set; }
        public virtual AdminStatus AcceptStatus { get; set; }
    }
}

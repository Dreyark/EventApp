using System.ComponentModel.DataAnnotations;

namespace EventApp.Entities
{
    public class Purpose
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
        public List<Event> Events { get; set; }
    }
}

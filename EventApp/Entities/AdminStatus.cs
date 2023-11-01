using System.ComponentModel.DataAnnotations;

namespace EventApp.Entities
{
    public class AdminStatus
    {
        [Key]
        public int Id { get; set; }
        public required string Name { get; set; }
    }
}
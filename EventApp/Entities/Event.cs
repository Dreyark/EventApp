using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApp.Entities
{

    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Name { get; set; } = string.Empty;
        [Column(TypeName = "nvarchar(2000)")]
        public string Description { get; set; } = string.Empty;
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Purpose> Purpose { get; set; } = new List<Purpose>();
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        public int AdminStatusId { get; set; }
        public virtual AdminStatus AdminStatus { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string User{ get; set; } = string.Empty;
    }
}

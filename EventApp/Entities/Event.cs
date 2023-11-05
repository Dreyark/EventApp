using EventApp.Helper;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EventApp.Entities
{

    public class Event
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Nazwa wydarzenia jest obowiązkowa")]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; } = string.Empty;
        [MaxLength(2000)]
        [Column(TypeName = "nvarchar(2000)")]
        public string Description { get; set; } = string.Empty;
        [Required]
        [Range(1, 5, ErrorMessage = "Typ musi być wybrany")]
        public int TypeId { get; set; }
        public virtual Type Type { get; set; }
        [StartDateValidation]
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public virtual List<Purpose> Purpose { get; set; }
        [Required]
        [Range(1, 4, ErrorMessage = "Status musi być wybrany")]
        public int StatusId { get; set; }
        public virtual Status Status { get; set; }
        [Required]
        public int AdminStatusId { get; set; }
        public virtual AdminStatus AdminStatus { get; set; }
        [Column(TypeName = "nvarchar(256)")]
        public string User{ get; set; } = string.Empty;
    }
}

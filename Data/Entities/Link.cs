using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Entities
{
    [Table("Links")]
    public class Link
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string? LongURl { get; set; }

        [Required]
        public string? ShortURL { get; set; }

        [Required]
        [Column(TypeName = "date")]
        [MaxLength(20)]
        public DateTime Date { get; set; }

        [Required]
        public int VisitsNumber { get; set; }
    }
}

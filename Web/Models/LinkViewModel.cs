using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class LinkViewModel
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Не указана ссылка")]
        public string? LongURl { get; set; }
    }
}

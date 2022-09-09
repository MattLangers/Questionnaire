using System.ComponentModel.DataAnnotations;

namespace Database.Models
{
    public class Questionnaire
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; } = default!;
    }
}

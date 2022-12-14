using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    [Table(name: "Questionnaire")]
    public class Questionnaire
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; }

        public Guid AuthorId { get; set; }

        [Required]
        public Author Author { get; set; } = default!;

        public DateTime CreatedDate { get; set; } = default!;
    
        [Required]
        [StringLength(200)]
        public string Name { get; set; } = default!;

        public bool IsDeleted { get; set; } = default!;
    }
}

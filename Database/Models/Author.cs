using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models
{
    [Table(name: "Author")]
    public class Author
    {
        public Guid Id { get; set; }

        public Guid OrganisationId { get; set; }

        public Organisation Organisation { get; set; } = default!;

        [Required]
        [StringLength(100)]
        public string Forename { get; set; } = default!;

        [Required]
        [StringLength(200)]
        public string Surname { get; set; } = default!;

        public ICollection<Questionnaire> Questionnaires { get; set; } = new List<Questionnaire>();
    }
}

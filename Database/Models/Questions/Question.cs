using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database.Models.Questions
{
    [Table("Question")]
    public class Question
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid Id { get; set; } = default!;

        [Required, MaxLength(150)]
        public string Name { get; set; } = default!;

        public DateTime CreatedDate { get; set; } = default!;

        public bool IsDeleted { get; set; } = default!;

        public Guid QuestionnaireId { get; set; } = default!;

        public Questionnaire Questionnaire { get; set; } = default!;
    }
}

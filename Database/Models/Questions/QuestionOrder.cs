using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Database.Models.Questions
{
    public class QuestionOrder
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        public Guid QuestionnaireId { get; set; }

        public Guid QuestionId { get; set; }

        public int Order { get; set; }
    }
}

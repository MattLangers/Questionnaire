using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class QuestionnaireDatabaseContext : DbContext
    {
        public QuestionnaireDatabaseContext(
            DbContextOptions<QuestionnaireDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Questionnaire> Questionnaires { get; set; }
    }
}

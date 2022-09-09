using Database.Models;
using Database.Models.Questions;
using Database.Seed.Factories;
using Microsoft.EntityFrameworkCore;

namespace Database
{
    public class QuestionnaireDatabaseContext : DbContext
    {
        private readonly IDatabaseSeedingFactory databaseSeedingFactory = new DatabaseSeedingFactory();

        public QuestionnaireDatabaseContext(
            DbContextOptions<QuestionnaireDatabaseContext> options)
            : base(options)
        {
        }

        public DbSet<Author> Authors { get; set; } = default!;

        public DbSet<Question> Questions { get; set; } = default!;

        public DbSet<QuestionType> QuestionTypes { get; set; } = default!;

        public DbSet<Questionnaire> Questionnaires { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasIndex(a => a.Id);
            modelBuilder.Entity<Author>().Property(a => a.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
            modelBuilder.Entity<Author>().Property(a => a.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
            modelBuilder.Entity<Author>().HasData(databaseSeedingFactory.CreateAuthors());

            modelBuilder.Entity<Organisation>().Property(a => a.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
            modelBuilder.Entity<Organisation>().Property(a => a.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
            modelBuilder.Entity<Organisation>().HasData(databaseSeedingFactory.CreateOrganisations());

            modelBuilder.Entity<Question>().Property(a => a.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
            modelBuilder.Entity<Question>().Property(a => a.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
            modelBuilder.Entity<Question>().Property(a => a.IsDeleted).HasDefaultValue(false);

            modelBuilder.Entity<Questionnaire>().Property(a => a.Id).HasDefaultValueSql("NEWSEQUENTIALID()");
            modelBuilder.Entity<Questionnaire>().Property(a => a.CreatedDate).HasDefaultValueSql("GETUTCDATE()");
            modelBuilder.Entity<Questionnaire>().Property(a => a.IsDeleted).HasDefaultValue(false);
        }
    }
}

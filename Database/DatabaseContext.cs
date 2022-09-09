using Database.Models;
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

        public DbSet<Questionnaire> Questionnaires { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasIndex(a => a.Id);

            modelBuilder.Entity<Author>().HasData(databaseSeedingFactory.CreateAuthors());

            modelBuilder.Entity<Organisation>().HasData(databaseSeedingFactory.CreateOrganisations());
        }
    }
}

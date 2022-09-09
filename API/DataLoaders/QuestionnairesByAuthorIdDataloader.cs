using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace API.DataLoaders
{
    public class QuestionnairesByAuthorIdDataloader : BatchDataLoader<Guid, Questionnaire>
    {
        private readonly IDbContextFactory<QuestionnaireDatabaseContext> _dbContextFactory;

        public QuestionnairesByAuthorIdDataloader(
            IBatchScheduler batchScheduler,
            IDbContextFactory<QuestionnaireDatabaseContext> dbContextFactory)
            : base(batchScheduler)
        {
            _dbContextFactory = dbContextFactory ??
                throw new ArgumentNullException(nameof(dbContextFactory));
        }

        protected override async Task<IReadOnlyDictionary<Guid, Questionnaire>> LoadBatchAsync(
            IReadOnlyList<Guid> keys,
            CancellationToken cancellationToken)
        {
            await using QuestionnaireDatabaseContext dbContext =
                _dbContextFactory.CreateDbContext();

            return await dbContext.Questionnaires
                .Where(q => keys.Contains(q.AuthorId))
                .ToDictionaryAsync(t => t.Id, cancellationToken);
        }
    }
}

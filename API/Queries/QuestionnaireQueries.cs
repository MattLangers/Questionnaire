using API.DataLoaders;
using API.Extensions;
using Database;
using Database.Models;
using Database.Models.Questions;
using Microsoft.EntityFrameworkCore;

namespace API.Queries
{
    public class QuestionnaireQueries
    {
        [UseApplicationDbContext]
        public Task<List<Questionnaire>> GetQuestionnaires([ScopedService] QuestionnaireDatabaseContext context) =>
            context.Questionnaires.ToListAsync();

        public Task<Questionnaire> GetQuestionnairesAsync(
            Guid authorId,
            QuestionnairesByAuthorIdDataloader dataLoader,
            CancellationToken cancellationToken) =>
            dataLoader.LoadAsync(authorId, cancellationToken);
    }
}

using API.Extensions;
using Database.Models;
using Database;

namespace API.Queries
{
    public class AuthorQueries
    {
        [UseApplicationDbContext]
        public Task<ICollection<Questionnaire>> GetAuthorsQuestionnaires([ScopedService] QuestionnaireDatabaseContext context) =>
            Task.Run(() => context.Authors.First().Questionnaires);
    }
}

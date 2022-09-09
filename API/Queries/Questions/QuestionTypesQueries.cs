using API.Extensions;
using Database;
using Database.Models.Questions;
using Microsoft.EntityFrameworkCore;

namespace API.Queries.Questions
{
    public class QuestionTypesQueries
    {
        [UseApplicationDbContext]
        public Task<List<QuestionType>> GetQuestionTypes([ScopedService] QuestionnaireDatabaseContext context) =>
            context.QuestionTypes.ToListAsync();
    }
}

using API.DataLoaders;
using API.Extensions;
using Database;
using Database.Models.Questions;
using Microsoft.EntityFrameworkCore;

namespace API.Queries.Questions
{
    public class QuestionsQueries
    {
        [UseApplicationDbContext]
        public Task<List<Question>> GetQuestions([ScopedService] QuestionnaireDatabaseContext context) =>
            context.Questions.ToListAsync();
    }
}

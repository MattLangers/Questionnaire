using API.Extensions;
using Database;
using Database.Models;
using Microsoft.EntityFrameworkCore;

namespace API.Queries
{
    public class QuestionnaireQueries
    {
        [UseApplicationDbContext]
        public Task<List<Questionnaire>> GetQuestionnaire([ScopedService] QuestionnaireDatabaseContext context) =>
            context.Questionnaires.ToListAsync();
    }
}

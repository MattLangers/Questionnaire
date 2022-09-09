using Database;
using Database.Models;

namespace API.Queries
{
    public class QuestionnaireQueries
    {
        public IQueryable<Questionnaire> GetQuestionnaire([Service] DatabaseContext context) =>
            context.Questionnaires;
    }
}

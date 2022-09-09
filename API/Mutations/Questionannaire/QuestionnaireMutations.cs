using API.Extensions;
using Database;
using Database.Models;
using static API.Mutations.Questionannaire.AddQuetionnaireInput;

namespace API.Mutations.Questionannaire
{
    public class QuestionnaireMutations
    {
        [UseApplicationDbContext]
        public async Task<AddQuestionnairePayload> AddQuestionnaireAsync(
            AddQuestionnaireInput input,
            [ScopedService] QuestionnaireDatabaseContext context)
        {
            var questionnaire = new Questionnaire
            {
                Name = input.Name,
            };

            context.Questionnaires.Add(questionnaire);
            await context.SaveChangesAsync();

            return new AddQuestionnairePayload(questionnaire);
        }
    }
}

using Database;
using Database.Models;
using static API.Mutations.Questionannaire.AddQuetionnaireInput;

namespace API.Mutations.Questionannaire
{
    public class QuestionnaireMutations
    {
        public async Task<AddQuestionnairePayload> AddQuestionnaireAsync(
            AddQuestionnaireInput input,
            [Service] DatabaseContext context)
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

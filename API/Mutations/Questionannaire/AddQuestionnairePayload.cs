using Database.Models;

namespace API.Mutations.Questionannaire
{
    public class AddQuestionnairePayload
    {
        public AddQuestionnairePayload(Questionnaire questionnaire)
        {
            Questionnaire = questionnaire;
        }

        public Questionnaire Questionnaire { get; }
    }
}

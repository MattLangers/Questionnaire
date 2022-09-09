namespace API.Mutations.Questionannaire
{
    public class AddQuetionnaireInput
    {
        public record AddQuestionnaireInput(string QuestionnaireName, Guid AuthorId);
    }
}

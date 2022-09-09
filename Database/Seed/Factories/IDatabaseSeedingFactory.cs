using Database.Models;

namespace Database.Seed.Factories
{
    internal interface IDatabaseSeedingFactory
    {
        IList<Author> CreateAuthors();

        IList<Organisation> CreateOrganisations();
    }
}

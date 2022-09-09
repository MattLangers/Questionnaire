using Database.Models;
using Database.Seed.Enums;
using FastEnumUtility;

namespace Database.Seed.Factories
{
    internal class DatabaseSeedingFactory : IDatabaseSeedingFactory
    {
        public IList<Author> CreateAuthors()
        {
            var values = FastEnum.GetValues<Enums.Authors>();
            var authors = new List<Author>();

            foreach (var value in values)
            {
#pragma warning disable CS8602 // Dereference of a possibly null reference.
                var memberValue = value.GetEnumMemberValue().Split(" ");
#pragma warning restore CS8602 // Dereference of a possibly null reference.
#pragma warning disable CS8604 // Possible null reference argument.
                authors.Add(new Author()
                {
                    Id = Guid.Parse(value.GetLabel()),
                    Forename = memberValue[0],
                    Surname = memberValue[1],
                    OrganisationId = Guid.Parse(Organisations.TestOrganisation.GetLabel()),
                });
#pragma warning restore CS8604 // Possible null reference argument.
            }

            return authors;
        }

        public IList<Organisation> CreateOrganisations()
        {
            var values = FastEnum.GetValues<Enums.Organisations>();
            var authors = new List<Organisation>();

            foreach (var value in values)
            {
#pragma warning disable CS8604 // Possible null reference argument.
#pragma warning disable CS8601 // Possible null reference assignment.
                authors.Add(new Organisation()
                {
                    Id = Guid.Parse(value.GetLabel()),
                    Name = value.GetEnumMemberValue()
                });;
#pragma warning restore CS8601 // Possible null reference assignment.
#pragma warning restore CS8604 // Possible null reference argument.
            }

            return authors;
        }
    }
}

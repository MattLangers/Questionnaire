using Database;
using HotChocolate.Types.Descriptors;
using System.Reflection;

namespace API.Extensions
{
    public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
    {
        public override void OnConfigure(
            IDescriptorContext context,
            IObjectFieldDescriptor descriptor,
            MemberInfo member)
        {
            descriptor.UseDbContext<QuestionnaireDatabaseContext>();
        }
    }
}

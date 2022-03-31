using System.Reflection;
using HotChocolate.Types.Descriptors;

namespace API.Data.Extensions;

public class UseApplicationDbContextAttribute : ObjectFieldDescriptorAttribute
{
    public override void OnConfigure(
        IDescriptorContext context,
        IObjectFieldDescriptor descriptor,
        MemberInfo member)
    {
        descriptor.UseDbContext<ApplicationDbContext>();
    }
}

using API.Data;
using API.Data.Extensions;

namespace API.Entities.MyFirst;

[ExtendObjectType("Query")]
public class MyFirstQuery
{
    [UseDbContext(typeof(ApplicationDbContext))]
    [UseProjection]
    [UseFiltering]
    [UseSorting]
    public IQueryable<MyFirstSchema> GetFirstQueries ([ScopedService] ApplicationDbContext context) => context.MyFirstQueries;
}

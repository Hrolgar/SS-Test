using API.Data;
using API.Entities.MyFirst;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("Test.API");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine($"Using ConnectionString: {connectionString}");
builder.Services.AddPooledDbContextFactory<ApplicationDbContext>(
    options =>
    {
        options.UseSqlServer(connectionString);
    });

var graphQlServer = builder.Services.AddGraphQLServer();
graphQlServer
    .AddQueryType(q => q.Name("Query"))
    .AddTypeExtension<MyFirstQuery>()
    .AddFiltering()
    .AddSorting()
    .AddProjections()
    ;
builder.Services.AddCors();

var app = builder.Build();
app.UseCors(x => x.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin());
app.MapGraphQL();
app.Run();

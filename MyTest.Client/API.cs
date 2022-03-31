using StrawberryShake;

namespace MyTest.Client.API;

public class API
{
    private readonly IMyTestClient _client;
    public API()
    {
        var serviceCollection = new ServiceCollection();
        serviceCollection
            .AddMyTestClient()
            .ConfigureHttpClient(c => c.BaseAddress = new Uri("https://localhost:5000/graphql"));
        var serviceProvider = serviceCollection.BuildServiceProvider();
        _client = serviceProvider.GetRequiredService<IMyTestClient>();
    }
    
    public async Task<IOperationResult<IGetMyFirstQueryResult>> GetMyFirstQuery()
    {
        try
        {
            return await _client.GetMyFirstQuery.ExecuteAsync();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}

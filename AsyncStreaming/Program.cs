var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", IAsyncEnumerable<int>() =>
{
    var value = GetData();
    return value;
});

app.Run();

static async IAsyncEnumerable<int> GetData()
{
    for (var i = 1; i <= 1000; i++)
    {
        await Task.Delay(1000);
        yield return i;
    }
}
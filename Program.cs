using hot_defer.queries;

var builder = WebApplication.CreateBuilder(args);
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>().AddDirectiveType<DeferDirectiveType>().AddDirectiveType<StreamDirectiveType>();

var app = builder.Build();

app.MapGraphQL();

app.Run();

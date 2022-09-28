using hot_defer.queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services
    .AddGraphQLServer()
    .AddQueryType<QueryType>().AddDirectiveType<DeferDirectiveType>().AddDirectiveType<StreamDirectiveType>();

var app = builder.Build();

app.MapGraphQL();

app.Run();

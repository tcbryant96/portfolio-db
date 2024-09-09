using PortfolioBackend.Services;
using PortfolioBackend.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container
builder.Services.AddScoped<IProjectService, ProjectService>();

// Add GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Map GraphQL endpoint
app.MapGraphQL("/graphql");

app.Run();

public class Query
{
    public List<Project> GetProjects([Service] IProjectService projectService)
    {
        return projectService.GetProjects();
    }
}


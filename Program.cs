using PortfolioBackend.Services;
using PortfolioBackend.Models;

var builder = WebApplication.CreateBuilder(args);

// Define a CORS policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowSpecificOrigins",
        builder =>
        {
            builder.WithOrigins("http://localhost:8080")
                   .AllowAnyHeader()
                   .AllowAnyMethod();
        });
});

// Add services to the container
builder.Services.AddScoped<IProjectService, ProjectService>();
builder.Services.AddScoped<INavigationService, NavigationService>();
builder.Services.AddScoped<IProfileService, ProfileService>();

// Add GraphQL services
builder.Services
    .AddGraphQLServer()
    .AddQueryType<Query>();

var app = builder.Build();

// Use CORS middleware
app.UseCors("AllowSpecificOrigins");

// Map GraphQL endpoint
app.MapGraphQL("/graphql");

app.Run();

public class Query
{
    private readonly IProjectService _projectService;
    private readonly INavigationService _navigationService;
    private readonly IProfileService _profileService;

    public Query(IProjectService projectService, INavigationService navigationService, IProfileService profileService)
    {
        _projectService = projectService;
        _navigationService = navigationService;
        _profileService = profileService;
    }

    public List<Project> GetProjects() => _projectService.GetProjects();
    public List<NavigationLink> GetNavigationLinks() => _navigationService.GetNavigationLinks();
    public Profile GetProfile() => _profileService.GetProfile();
}

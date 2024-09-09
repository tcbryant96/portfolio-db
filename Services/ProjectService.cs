using Newtonsoft.Json;
using PortfolioBackend.Models;
using Path = System.IO.Path;

namespace PortfolioBackend.Services
{
    public class ProjectService : IProjectService
    {
        private readonly string _dataFile = Path.Combine(Directory.GetCurrentDirectory(), "Data", "projects.json");

        public List<Project> GetProjects()
        {
            var jsonData = File.ReadAllText(_dataFile);
            var projects = JsonConvert.DeserializeObject<List<Project>>(jsonData);
            return projects;
        }
    }
}

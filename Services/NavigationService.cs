using Newtonsoft.Json;
using PortfolioBackend.Models;
using Path = System.IO.Path;

namespace PortfolioBackend.Services
{
    public class NavigationService : INavigationService
    {
        private readonly string _dataFile = Path.Combine(Directory.GetCurrentDirectory(), "Data", "navigation.json");

        public List<NavigationLink> GetNavigationLinks()
        {
            var jsonData = File.ReadAllText(_dataFile);
            var links = JsonConvert.DeserializeObject<List<NavigationLink>>(jsonData);
            return links;
        }
    }
}

using Newtonsoft.Json;
using PortfolioBackend.Models;
using System.IO;
using Path = System.IO.Path;

namespace PortfolioBackend.Services
{
    public class ProfileService : IProfileService
    {
        private readonly string _dataFile = Path.Combine(Directory.GetCurrentDirectory(), "Data", "profile.json");

        public Profile GetProfile()
        {
            var jsonData = File.ReadAllText(_dataFile);
            var profile = JsonConvert.DeserializeObject<Profile>(jsonData);
            return profile;
        }
    }
}

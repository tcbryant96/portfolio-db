namespace PortfolioBackend.Models
{
    public class NavigationLink
    {
        public string Name { get; set; }
        public string Url { get; set; }

        // Constructor
        public NavigationLink()
        {
            Name = string.Empty;
            Url = string.Empty;
        }
    }
}

namespace PortfolioBackend.Models
{
    public class Profile
    {
        public string Name { get; set; }
        public string Intro { get; set; }
        public string Bio { get; set; }

        // Constructor to avoid null reference warnings
        public Profile()
        {
            Name = string.Empty;
            Intro = string.Empty;
            Bio = string.Empty;
        }
    }
}
